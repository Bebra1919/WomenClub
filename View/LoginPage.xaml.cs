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
using WomenClub.Model;

namespace WomenClub.View
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Window LoginWindow;
        Users user;
        public LoginPage(Window loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
        }

        private void RegTextClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ManWindow manWindow = new ManWindow(user);
            manWindow.Show();
            LoginWindow.Close();
        }
    }
}
