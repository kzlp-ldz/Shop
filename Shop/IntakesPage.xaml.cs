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
    /// Логика взаимодействия для IntakesPage.xaml
    /// </summary>
    public partial class IntakesPage : Page
    {
        public static ObservableCollection<ProductIntake> Intakes { get; set; }
        public static ObservableCollection<ProductIntakeProduct> productIntakeProducts { get; set; }
        public static ObservableCollection<Worker> workers { get; set; }
        public IntakesPage()
        {
            InitializeComponent();
            Intakes = new ObservableCollection<ProductIntake>(bd_connection.shop.ProductIntake.ToList());
            DataContext = this;
        }

        private void btn_AddInt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В режиме разработки");
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
