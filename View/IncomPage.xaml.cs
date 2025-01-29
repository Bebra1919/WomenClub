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
using LiveCharts.Wpf;
using LiveCharts;

namespace WomenClub.View
{
    /// <summary>
    /// Логика взаимодействия для IncomPage.xaml
    /// </summary>
    public partial class IncomPage : Page
    {
        public IncomPage()
        {
            InitializeComponent();
            pieChart.Series = new SeriesCollection()
            {
                new PieSeries
                {
                    Values = new ChartValues<double> {20},
                    DataLabels = true,
                    LabelPoint = charPoint => $"{charPoint.Y}({charPoint.Participation:P})"

                }
            };
            pieChart.LegendLocation = LegendLocation.Right;
        }
    }
}
