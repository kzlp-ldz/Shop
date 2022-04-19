using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        Product product = new Product();
        public int actualPage;
        public ProductPage()
        {
            InitializeComponent();
            ProductList.ItemsSource = bd_connection.shop.Product.ToList();
            var LvUnit = bd_connection.shop.Unit.ToList();
            LvUnit.Insert(0, new Unit() { Id = -1, Name = "Все" });
            UnitCb.ItemsSource = LvUnit;
            UnitCb.DisplayMemberPath = "Name";
        }

        private void AddBtnt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void EditBtnt_Click(object sender, RoutedEventArgs e)
        {
            var isSelected = ProductList.SelectedItem as Product;

            if (isSelected != null)
                NavigationService.Navigate(new EditPage(isSelected));
            else
                MessageBox.Show("Выберите продукт из списка");
        }

        private void DelBtnt_Click(object sender, RoutedEventArgs e)
        {
            var isSelProduct = ProductList.SelectedItem as Product;
            if (isSelProduct != null)
            {
                var result = MessageBox.Show("Удалить?", "", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.OK)
                {
                   
                    bd_connection.shop.Product.Remove(isSelProduct);
                    bd_connection.shop.SaveChanges();
                    ProductList.ItemsSource = bd_connection.shop.Product.ToList();
                }

            }
            else
                MessageBox.Show("Ничего не выбрано!");

        }
        private void Refresh()
        {
            var FilterProduct = (IEnumerable<Product>)bd_connection.shop.Product.ToList();

            if (!string.IsNullOrWhiteSpace(SearchNameDescTb.Text))
                FilterProduct = FilterProduct.Where(c => c.Name.StartsWith(SearchNameDescTb.Text) || c.Description.StartsWith(SearchNameDescTb.Text));

            if (UnitCb.SelectedIndex > 0)
                FilterProduct = FilterProduct.Where(c => c.UnitId == (UnitCb.SelectedItem as Unit).Id || c.UnitId == -1);

            //if (DateMounthBtn.IsPressed)
            //{
            //    var date = DateTime.Now.Month;
            //    ProductList.ItemsSource = FilterProduct.Where(c => c.AddDate.Month == date);
            //}

            if (DateCb.SelectedIndex == 1)
                FilterProduct = FilterProduct.OrderBy(c => c.AddDate);
            else if (DateCb.SelectedIndex == 2)
                FilterProduct = FilterProduct.OrderByDescending(c => c.AddDate);

            if (AlfCb.SelectedIndex == 1)
                FilterProduct = FilterProduct.OrderBy(c => c.Name);
            else if (AlfCb.SelectedIndex == 2)
                FilterProduct = FilterProduct.OrderByDescending(c => c.Name);


            if (SortCount.SelectedIndex > 0 && FilterProduct.Count() > 0)
            {
                var cbb = SortCount.SelectedItem as ComboBoxItem;
                int SelCount = Convert.ToInt32(cbb.Content);
                FilterProduct = FilterProduct.Skip(SelCount * actualPage).Take(SelCount);
                if (FilterProduct.Count() == 0)
                {
                    actualPage--;
                    return;
                }
                ProductList.ItemsSource = FilterProduct;
            }

            ProductList.ItemsSource = FilterProduct;
        }

        private void UnitCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void SearchNameDescTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void DateMounthBtn_Click(object sender, RoutedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void DateCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void AlfCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void SortCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }

        private void ForwardListBtn_Click(object sender, RoutedEventArgs e)
        {
            actualPage++;
            Refresh();
        }

        private void BackListBtn_Click(object sender, RoutedEventArgs e)
        {
            actualPage--;
            if (actualPage < 0)
                actualPage = 0;
            Refresh();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            actualPage = 0;
            Refresh();
        }
        private void ProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
