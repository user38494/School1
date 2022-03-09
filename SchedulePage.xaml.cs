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
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SchedulePageEdit((sender as Button).DataContext as Schedule));
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SchedulePageEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var schedulesForRemoving = DGridStudentsPage.SelectedItems.Cast<Schedule>().ToList();
            if (MessageBox.Show("asdasd", "asdasd", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                School1Entities.GetContext().Schedules.RemoveRange(schedulesForRemoving);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Data save");
                DGridStudentsPage.ItemsSource = School1Entities.GetContext().Schedules.ToList();
            }

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Schedules.Where(x => x.Class.Title.ToString().Contains(Poisk.Text.ToString())).ToList();
        }

        private void Filtr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Schedules.Where(x => x.Class.Title == Filtr.SelectedItem.ToString()).ToList();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = DGridStudentsPage.ItemsSource.Cast<Schedule>().ToList();
            switch (Sort.SelectedItem.ToString())
            {
                case "Предмет":
                    DGridStudentsPage.ItemsSource = list.OrderBy(x => x.Lesson.Title);
                    break;
                case "Кабинет":
                    DGridStudentsPage.ItemsSource = list.OrderBy(x => x.Classroom.Title);
                    break;
                case "Учитель":
                    DGridStudentsPage.ItemsSource = list.OrderBy(x => x.Teacher);
                    break;
            }

        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Schedules.Where(x => x.Class.Title == Filtr.SelectedItem.ToString()).ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Schedules.ToList();
            Filtr.ItemsSource = School1Entities.GetContext().Schedules.GroupBy(x => x.Class.Title).Select(x => x.Key).ToList();
            Sort.ItemsSource = new List<string>
            {
                "Класс", "Предмет", "Кабинет", "Учитель"
            };
        }
    }
}
