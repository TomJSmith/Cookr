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
    /// Interaction logic for TopRatedView.xaml
    /// </summary>
    public partial class TopRatedView : UserControl
    {
        private MainWindow myMain;
        public TopRatedView(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }


        private void defaultView()
        {
            Sp1.Children.Clear();

            ListItem item1ListItem = new ListItem(myMain.spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem( myMain.beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem(myMain.hawiianSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem( myMain.orangeAvoChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem(myMain.stirFry);
            Sp1.Children.Add(item5ListItem);
        }

        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {
            Sp1.Children.Clear();

            ListItem item5ListItem = new ListItem(myMain.stirFry);
            Sp1.Children.Add(item5ListItem);

            ListItem item2ListItem = new ListItem( myMain.beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem(myMain.hawiianSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem(myMain.orangeAvoChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem(myMain.spaghetti);
            Sp1.Children.Add(item1ListItem);
        }



        private void TimeSelected(object sender, RoutedEventArgs e)
        {
            Sp1.Children.Clear();

            ListItem item3ListItem = new ListItem(myMain.hawiianSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item2ListItem = new ListItem(myMain.beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item4ListItem = new ListItem(myMain.orangeAvoChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem(myMain.spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item5ListItem = new ListItem(myMain.stirFry);
            Sp1.Children.Add(item5ListItem);
        
        
        
        
        }

        private void RatingSelected(object sender, RoutedEventArgs e)
        {
            Sp1.Children.Clear();

            ListItem item1ListItem = new ListItem(myMain.spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem(myMain.beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem( myMain.hawiianSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem(myMain.orangeAvoChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem(myMain.stirFry);
            Sp1.Children.Add(item5ListItem);
        }
    }

}