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

namespace School1
{
    /// <summary>
    /// Логика взаимодействия для aut.xaml
    /// </summary>
    public partial class aut : Page
    {
        public aut()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && School1Entities.GetContext().Users.Any(x => x.login == Login.Text))
            {
                if (School1Entities.GetContext().Users.Any(x => x.login == Login.Text && x.password == Password.Password))
                {
                    Manager.MainFrame.Navigate(new MenuPage());
                }
                else
                    MessageBox.Show("Пароль не верный!");
            }
            else
                MessageBox.Show("Такого пользователя не существует!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new reg());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
