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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void BtnSupp3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SchedulePage());
        }

        private void BtnSupp4_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TeacherPage());
        }

        private void BtnSupp2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LessonPage());
        }

        private void BtnSupp1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassroomPage());
        }

        private void BtnSupp_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClassPage());
        }
    }
}
