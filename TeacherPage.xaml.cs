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
    /// Логика взаимодействия для TeacherPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage()
        {
            InitializeComponent();
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Teachers.ToList();
            Filtr.ItemsSource = School1Entities.GetContext().Teachers.GroupBy(x => x.Title).Select(x => x.Key).ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TeacherPageEdit((sender as Button).DataContext as Teacher));
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TeacherPageEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var teachersForRemoving = DGridStudentsPage.SelectedItems.Cast<Teacher>().ToList();
            if (MessageBox.Show("asdasd", "asdasd", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                School1Entities.GetContext().Teachers.RemoveRange(teachersForRemoving);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Data save");
                DGridStudentsPage.ItemsSource = School1Entities.GetContext().Teachers.ToList();
            }

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Teachers.Where(x => x.Title.ToString().Contains(Poisk.Text.ToString())).ToList();
        }


        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Teachers.Where(x => x.Title == Filtr.SelectedItem.ToString()).ToList();
        }

    }
}
