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
    /// Логика взаимодействия для ClassPage.xaml
    /// </summary>
    public partial class ClassPage : Page
    {
        public ClassPage()
        {
            InitializeComponent();
            DGridClasses.ItemsSource = School1Entities.GetContext().Classes.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassPageEdit((sender as Button).DataContext as Class));
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassPageEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var classesForRemoving = DGridClasses.SelectedItems.Cast<Class>().ToList();
            if (MessageBox.Show("asdasd", "asdasd", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                School1Entities.GetContext().Classes.RemoveRange(classesForRemoving);
                School1Entities.GetContext().SaveChanges();
                MessageBox.Show("Data save");
                DGridClasses.ItemsSource = School1Entities.GetContext().Classes.ToList();
            }

        }
    }
}
