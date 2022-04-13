using Microsoft.Win32;
using Shop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Product product = new Product();
        public EditPage(Product prod)
        {
            InitializeComponent();
            cbx_country.ItemsSource = bd_connection.shop.Country.ToList();
            cbx_country.DisplayMemberPath = "Name";

            cbx_unit.ItemsSource = bd_connection.shop.Unit.ToList();
            cbx_unit.DisplayMemberPath = "Name";

            product = prod;

            this.DataContext = product;

            if (product.Id != 0)
            {
                btn_addCountry.Visibility = Visibility.Visible;
                btn_delCountry.Visibility = Visibility.Visible;
                lb_country.Visibility = Visibility.Visible;
                cbx_country.Visibility = Visibility.Visible;
                lv_country.Visibility = Visibility.Visible;
            }
        }
        private void btn_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg",
            };

            if (openFile.ShowDialog().GetValueOrDefault())
            {
                product.Photo = File.ReadAllBytes(openFile.FileName);
                img_photo.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            product.UnitId = (cbx_unit.SelectedItem as Unit).Id;
            product.AddDate = DateTime.Now;
            if (product.Id == 0) bd_connection.shop.Product.Add(product);

            bd_connection.shop.SaveChanges();

            btn_addCountry.Visibility = Visibility.Visible;
            btn_delCountry.Visibility = Visibility.Visible;
            lb_country.Visibility = Visibility.Visible;
            cbx_country.Visibility = Visibility.Visible;
            lv_country.Visibility = Visibility.Visible;
        }

        private void btn_addCountry_Click(object sender, RoutedEventArgs e)
        {
            if (cbx_country.SelectedIndex >= 0)
            {
                var prodCountry = new ProductCountry();
                var sel = cbx_country.SelectedItem as Country;

                prodCountry.ProductId = product.Id;
                prodCountry.CountryId = sel.Id;

                var isCountry = bd_connection.shop.ProductCountry.Where(c => c.CountryId == sel.Id && c.ProductId == product.Id).Count();

                if (isCountry == 0)
                {
                    bd_connection.shop.ProductCountry.Add(prodCountry);
                    bd_connection.shop.SaveChanges();
                    UpdateCountryList();
                }
            }
        }
        private void UpdateCountryList()
        {
            lv_country.ItemsSource = bd_connection.shop.ProductCountry.Where(e => e.ProductId == product.Id).ToList();
        }

        private void btn_delCountry_Click(object sender, RoutedEventArgs e)
        {
            if (lv_country.SelectedItem != null)
            {
                var selProductCountry = bd_connection.shop.ProductCountry.ToList().Find(c => c.ProductId == product.Id
                && c.CountryId == (lv_country.SelectedItem as ProductCountry).CountryId);
                bd_connection.shop.ProductCountry.Remove(selProductCountry);
                bd_connection.shop.SaveChanges();
                UpdateCountryList();
            }
        }
    }
}
