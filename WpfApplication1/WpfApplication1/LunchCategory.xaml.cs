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
    /// Interaction logic for LunchCategory.xaml
    /// </summary>
    public partial class LunchCategory : UserControl
    {
        private MainWindow myMain;
        public LunchCategory(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }
        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }

        void defaultView()
        {
            ListItem item1 =  new ListItem(myMain.orangeAvoChicken.getName(),myMain.orangeAvoChicken.getTime(),myMain.orangeAvoChicken);
            Sp1.Children.Add(item1);
            ListItem item2 = new ListItem(myMain.stirFry.getName(),myMain.stirFry.getTime(),myMain.stirFry);
            Sp1.Children.Add(item2);

        }
    }
}
