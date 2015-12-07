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
    /// Interaction logic for BreakfastCategory.xaml
    /// </summary>
    public partial class BreakfastCategory : UserControl
    {
        private MainWindow myMain;
        public BreakfastCategory(MainWindow aMain)
        {
            InitializeComponent();
            myMain = aMain;
            defaultView();

        }

        void defaultView()
        {

            Sp1.Children.Clear();



            ListItem item1 =  new ListItem(myMain.pancake.getName(),myMain.pancake.getTime(),myMain.pancake);

            RecipeView ar = new RecipeView("Alfredo", "30 min", 5);
            RecipeView br = new RecipeView("Chicken Linguini", "35 min", 4);
            RecipeView cr = new RecipeView("Penne", "27 min", 3.5);
            RecipeView dr = new RecipeView("Mac and Cheese", "32 min", 3);
            RecipeView er = new RecipeView("Fetuccini", "30 min", 3);
            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(myMain.spaghetti);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem el = new ListItem(dr);
            ListItem fl = new ListItem(er);

            


            Sp1.Children.Add(item1);


        }
    
    
    }// end of BreakfastCategory


} // end of namespace
