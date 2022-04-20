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
using System.Collections.ObjectModel;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public static ObservableCollection<ProductOrder> productsOrder { get; set; }
        //public static DateBasee.Order order;
        public static int Count = 0;
        Order NewOrderID = new Order();
        public AddOrderPage()
        {
            InitializeComponent();
            cb_prod.ItemsSource = bd_connection.shop.Product.ToList();
            cb_prod.DisplayMemberPath = "Name";
            this.DataContext = this;
        }
        public void UpdateProd()
        {
            dg_newOrder.ItemsSource = bd_connection.shop.ProductOrder.Where(a => a.OrderId == NewOrderID.Id).ToList();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage(ProductPage.user));
        }

        

        private void btn_prod_Click(object sender, RoutedEventArgs e)
        {
            if (Count == 0)
            {
                NewOrderID = bd_connection.shop.Order.Add(new Order
                {
                    Date = DateTime.Now,
                    StatusOrderId = 1,
                    ClientId = ProductPage.user.Id

                });
                bd_connection.shop.SaveChanges();
                //order.ClientId = ListPage.user.Id;
                //order.StatusOrder = 1;
                //order.Date = DateTime.Now;
                //bd_connection.connection.Order.Add(order);
                Count++;
            }
            if (cb_prod.SelectedIndex >= 0 && tb_alown.Text != null)
            {
                var ProdOrder = new ProductOrder();
                var selectProd = cb_prod.SelectedItem as Product;
                ProdOrder.ProductId = selectProd.Id;
                ProdOrder.OrderId = NewOrderID.Id;
                ProdOrder.Count = Convert.ToInt32(tb_alown.Text);
                var isProduct = bd_connection.shop.ProductOrder.Where(a => a.ProductId == selectProd.Id && a.OrderId == NewOrderID.Id).Count();
                if (isProduct == 0)
                {
                    bd_connection.shop.ProductOrder.Add(ProdOrder);
                    bd_connection.shop.SaveChanges();
                    UpdateProd();
                }
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}