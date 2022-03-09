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
    /// Логика взаимодействия для LessonPage.xaml
    /// </summary>
    public partial class LessonPage : Page
    {
        public LessonPage()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LessonPageEdit((sender as Button).DataContext as Lesson));
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LessonPageEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var lessonsForRemoving = DGridStudentsPage.SelectedItems.Cast<Lesson>().ToList();
            if (MessageBox.Show("asdasd", "asdasd", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                School1Entities.GetContext().Lessons.RemoveRange(lessonsForRemoving);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Data save");
                DGridStudentsPage.ItemsSource = School1Entities.GetContext().Lessons.ToList();
            }

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Lessons.Where(x => x.Title.ToString().Contains(Poisk.Text.ToString())).ToList();
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Lessons.Where(x => x.Title == Filtr.SelectedItem.ToString()).ToList();
        }

        private void Sort_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var list = DGridStudentsPage.ItemsSource.Cast<Lesson>().ToList();
            switch (Sort.SelectedItem.ToString())
            {
                case "Название предмета":
                    DGridStudentsPage.ItemsSource = list.OrderBy(x => x.Title);
                    break;
                case "Имя преподавателя":
                    DGridStudentsPage.ItemsSource = list.OrderBy(x => x.Title);
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var enumerable = new List<Lesson>();
            School1Entities.GetContext().Lessons.ToList().ForEach(x =>
            {
                enumerable.Add(new Lesson()
                {
                    ID = x.ID,
                    Title = x.Title,
                    Teacher = x.Teachers.ToList().FirstOrDefault()
                });
            });
            DGridStudentsPage.ItemsSource = enumerable;
            Filtr.ItemsSource = School1Entities.GetContext().Lessons.GroupBy(x => x.Title).Select(x => x.Key).ToList();
            Sort.ItemsSource = new List<string>
            {
                "Название предмета", "Имя преподавателя"
            };
        }
    }
}
