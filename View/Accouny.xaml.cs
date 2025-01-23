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

namespace WomenClub.View
{
    /// <summary>
    /// Логика взаимодействия для Accouny.xaml
    /// </summary>
    public partial class Accouny : Page
    {
        public Accouny(User user)
        {
            InitializeComponent();
            NameTextBlock.Text = $"{user.getName()} {user.getSurname()}";
            IdTextBlock.Text = $"ID: {user.getId()}"; 
        }
    }
}
