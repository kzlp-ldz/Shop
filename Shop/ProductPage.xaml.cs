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
        public ProductPage()
        {
            InitializeComponent();
            ProductList.ItemsSource = bd_connection.shop.Product.ToList();
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

        }

        private void ProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
