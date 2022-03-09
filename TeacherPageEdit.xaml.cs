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
    /// Логика взаимодействия для TeacherPageEdit.xaml
    /// </summary>
    public partial class TeacherPageEdit : Page
    {
        Teacher _currentTeacher;
        public TeacherPageEdit()
        {
            InitializeComponent();
            _currentTeacher = new Teacher();
            DataContext = _currentTeacher;
        }
        public TeacherPageEdit(Teacher cl)
        {
            InitializeComponent();
            _currentTeacher = cl;
            DataContext = _currentTeacher;
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
                if (_currentTeacher.ID == 0)
                    School1Entities.GetContext().Teachers.Add(_currentTeacher);
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
