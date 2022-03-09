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
    /// Логика взаимодействия для SchedulePageEdit.xaml
    /// </summary>
    public partial class SchedulePageEdit : Page
    {
        Schedule _currentSchedule;
        public SchedulePageEdit()
        {
            InitializeComponent();
            _currentSchedule = new Schedule();
            getComboBox();
            DataContext = _currentSchedule;
            _currentSchedule.Date = DateTime.Now;
        }
        public SchedulePageEdit(Schedule cl)
        {
            InitializeComponent();
            _currentSchedule = cl;
            getComboBox();
            DataContext = _currentSchedule;
        }
        private void getComboBox()
        {
            CbLesson.ItemsSource = School1Entities.GetContext().Lessons.ToList();
            CbClass.ItemsSource = School1Entities.GetContext().Classes.ToList();
            CbClassroom.ItemsSource = School1Entities.GetContext().Classrooms.ToList();
            CbTeacher.ItemsSource = School1Entities.GetContext().Teachers.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CbTeacher.SelectedItem == null || CbLesson.SelectedItem == null || CbClassroom.SelectedItem == null || CbClass.SelectedItem == null)
               MessageBox.Show("Заполните пожалуйста все поля", "", MessageBoxButton.OK);
            else
            {
                if (_currentSchedule.ID == 0)
                    School1Entities.GetContext().Schedules.Add(_currentSchedule);
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
