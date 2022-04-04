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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class BackgroundWindow : Window
    {
        public BackgroundWindow()
        {
            InitializeComponent();
            frame_auto_reg.NavigationService.Navigate(new AuthorizationPage());
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (frame_auto_reg.CanGoBack) frame_auto_reg.GoBack();
        }

        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (frame_auto_reg.CanGoForward) frame_auto_reg.GoForward();
        }
    }
}
