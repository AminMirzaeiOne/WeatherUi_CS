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

namespace WeatherUi.Controls
{
    /// <summary>
    /// Interaction logic for CardDay.xaml
    /// </summary>
    public partial class CardDay : UserControl
    {
        public static readonly DependencyProperty DayProperty = DependencyProperty.Register("Day", typeof(string), typeof(CardDay));
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(CardDay));


        public CardDay()
        {
            InitializeComponent();
        }
    }
}
