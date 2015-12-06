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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserRating.xaml
    /// </summary>
    public partial class UserRating : UserControl
    {
        public UserRating()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            userRating.Source = new BitmapImage(new Uri(@"/Images/1star.png", UriKind.Relative));
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            userRating.Source = new BitmapImage(new Uri(@"/Images/2star.png", UriKind.Relative));
        }

        private void button_Copy2_Click_1(object sender, RoutedEventArgs e)
        {
            userRating.Source = new BitmapImage(new Uri(@"/Images/3star.png", UriKind.Relative));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            userRating.Source = new BitmapImage(new Uri(@"/Images/4star.png", UriKind.Relative));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            userRating.Source = new BitmapImage(new Uri(@"/Images/5star.png", UriKind.Relative));
        }
    }
}
