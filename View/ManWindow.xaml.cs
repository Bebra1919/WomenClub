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
using System.Windows.Shapes;
using WomenClub.Model;

namespace WomenClub.View
{
    /// <summary>
    /// Логика взаимодействия для ManWindow.xaml
    /// </summary>
    public partial class ManWindow : Window
    {
        public Users user;
        public ManWindow(Users user)
        {
            InitializeComponent();
            ManFrame.Content = new HomePage();
            this.user = user;
        }

        private void DomImageClick(object sender, MouseButtonEventArgs e)
        {
            ManFrame.Content = new HomePage();
        }

        private void Incom(object sender, MouseButtonEventArgs e)
        {

        }

        private void IncomImageClick(object sender, MouseButtonEventArgs e)
        {
            ManFrame.Content = new IncomPage(); 
        }

        private void SpendImageClick(object sender, MouseButtonEventArgs e)
        {
            ManFrame.Content = new SpendPage();
        }

        private void AccountImageClick(object sender, MouseButtonEventArgs e)
        {
            ManFrame.Content = new Accouny(user);
        }

        private void SettingsImageClick(object sender, MouseButtonEventArgs e)
        {
            ManFrame.Content = new SettingsPage();
        }
    }
}
