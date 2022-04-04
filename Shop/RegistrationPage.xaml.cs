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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void regist_btn_Click(object sender, RoutedEventArgs e)
        {
            if(IsPasswordCorrect())
            {
                int role = 3;
                var new_user = new User();
                var new_client = new Client();

                new_user.Login = login_tbx.Text;
                new_user.Password = password_tbx.Password;
                new_user.RoleId = role;

                bd_connection.shop.User.Add(new_user);
                bd_connection.shop.SaveChanges();

                users = new ObservableCollection<User>(bd_connection.shop.User.ToList());

                new_client.FIO = fio_tbx.Text;
                if (gender_cbx.Text == "Мужской")
                {
                    new_client.GenderId = 1;
                }
                else if (gender_cbx.Text == "Женский")
                {
                    new_client.GenderId = 2;
                }

                new_client.NumberPhone = phone_tbx.Text;
                new_client.Email = email_tbx.Text;
                new_client.AddDate = DateTime.Now;
                new_client.UserId = users.Last().Id;

                bd_connection.shop.Client.Add(new_client);
                bd_connection.shop.SaveChanges();

                MessageBox.Show("OK");
                NavigationService.GoBack();
            }
        }
        public bool IsPasswordCorrect()
        {
            users = new ObservableCollection<User>(bd_connection.shop.User.ToList());
            bool login = true;
            foreach(var a in users)
            {
                if (a.Login == login_tbx.Text)
                    login = false;
            }
            if(login)
            {
                var password = password_tbx.Password;
                
                bool letters = false;
                bool nums = false;
                bool elements = false;

                foreach (var a in password)
                {
                    if (Char.IsLetter(a))
                        letters = true;
                }

                foreach (var a in password)
                {
                    if (Char.IsNumber(a))
                        nums = true;
                }

                foreach (var i in password)
                {
                    if (i == '!' || i == '@' || i == '#' || i == '$' || i == '%' || i == '^')
                        elements = true;
                }
                if (password.Length >= 6 && letters && nums && elements)
                    return true;
                else
                {
                    MessageBox.Show("Пароль должен содержать буквы, цифры и спец. символы", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Такой логин уже занят, придумайте другой", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        private void phone_tbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
