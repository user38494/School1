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
    /// Логика взаимодействия для ClassPageEdit.xaml
    /// </summary>
    public partial class ClassPageEdit : Page
    {
        Class _currentClass;
        public ClassPageEdit()
        {
            InitializeComponent();
            _currentClass = new Class();
            DataContext = _currentClass;
        }
        public ClassPageEdit(Class cl)
        {
            InitializeComponent();
            _currentClass = cl;
            DataContext = _currentClass;
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(Name.Text))
                MessageBox.Show("Заполните пожалуйста все поля", "", MessageBoxButton.OK);
            else
            {
                if (_currentClass.ID == 0)
                    School1Entities.GetContext().Classes.Add(_currentClass);
                try
                {
                   School1Entities.GetContext().SaveChanges();
               }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                MessageBox.Show("Вы успешно добавили/изменили заказчика");
                Manager.MainFrame.GoBack();
            }
        }

    }
}
