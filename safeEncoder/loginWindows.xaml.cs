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

namespace safeEncoder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login(object sender, RoutedEventArgs e)
        {

        }

        private void getFocus(object sender, RoutedEventArgs e)
        {

        }

        private void openAddNewUserWindow(object sender, MouseButtonEventArgs e)
        {
            addNewUser window = new addNewUser();
            window.Show();
        }
        
    }
}
