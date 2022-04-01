﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void auto_btn_Click(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(bd_connection.shop.User.ToList());
            var k = users.Where(a => a.Login == login_tbx.Text && a.Password == password_tbx.Password).FirstOrDefault();
            if (k != null)
                NavigationService.Navigate(new AuthorizationPage());
            else
                MessageBox.Show("Логин или пароль введены неверно", "error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
