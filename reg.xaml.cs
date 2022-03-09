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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        public reg()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && !School1Entities.GetContext().Users.Where(x => x.login == Login.Text).Any())
            {
                User user = new User();
                user.login = Login.Text;
                user.password = Password.Password;
                School1Entities.GetContext().Users.Add(user);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались!");
                Manager.MainFrame.GoBack();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
        }
    }
}
