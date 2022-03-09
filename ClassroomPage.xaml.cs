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
    /// Логика взаимодействия для ClassroomPage.xaml
    /// </summary>
    public partial class ClassroomPage : Page
    {
        public ClassroomPage()
        {
            InitializeComponent();
            DGridStudentsPage.ItemsSource = School1Entities.GetContext().Classrooms.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassroomPageEdit((sender as Button).DataContext as Classroom));
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassroomPageEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var classroomsForRemoving = DGridStudentsPage.SelectedItems.Cast<Classroom>().ToList();
            if (MessageBox.Show("asdasd", "asdasd", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                School1Entities.GetContext().Classrooms.RemoveRange(classroomsForRemoving);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Data save");
                DGridStudentsPage.ItemsSource = School1Entities.GetContext().Classrooms.ToList();
            }

        }

    }
}
