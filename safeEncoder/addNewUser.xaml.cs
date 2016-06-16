using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace safeEncoder
{
    /// <summary>
    /// Логика взаимодействия для addNewUser.xaml
    /// </summary>
    public partial class addNewUser : Window
    {
        public addNewUser()
        {
            InitializeComponent();
        }

        private void addNewUserBtnFunk(object sender, RoutedEventArgs e)
        {
            users userlist = new users();
            List<string> userList = new List<string>();
            userList = userlist.getUsers();

            if (userList.Contains(login.Text) == false)
            {
                var pass = passwordBox.Password;
                if (passwordBox.Password == passwordBox1.Password)
                {
                    users user = new users(login.Text, passwordBox.Password);
                }
                else
                {
                    MessageBox.Show("This user already exist");
                }
            }                   
        }
        private void showErrorPassword(object sender, EventArgs e)
        {
            passwordBox.BorderBrush = Brushes.DarkRed;
            passwordBox1.BorderBrush = Brushes.DarkRed;
            (sender as DispatcherTimer).Stop();
        }

        private void checkMutchPassword(object sender, RoutedEventArgs e)
        {
            string password = passwordBox.Password;
            string password1 = passwordBox1.Password;                        
            if(password!=password1)
            {
                passwordBox.BorderBrush = Brushes.DarkRed;
                passwordBox1.BorderBrush = Brushes.DarkRed;
                
            }
            else
            {
                passwordBox.BorderBrush = Brushes.Green;
                passwordBox1.BorderBrush = Brushes.Green;
            }
        }
    }
}
