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
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : UserControl
    {
        private MainWindow myMain;
        public SearchView()
        {
            InitializeComponent();
        }

        public void setMain(MainWindow aMain)
        {
            myMain = aMain;
        }

        public void initPasta()
        {
            RecipeView ar = new RecipeView("Alfredo", "30 min", 5);
            RecipeView br = new RecipeView("Linguini", "35 min", 4);
            RecipeView cr = new RecipeView("Penne", "27 min", 3.5);
            RecipeView dr = new RecipeView("Mac and Cheese", "32 min", 3);
            RecipeView er = new RecipeView("Fetuccini", "30 min", 3);
            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(myMain.spaghetti);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem el = new ListItem(dr);
            ListItem fl = new ListItem(er);

            items.Children.Clear();
            items.Children.Add(al);
            items.Children.Add(bl);
            items.Children.Add(cl);
            items.Children.Add(dl);
            items.Children.Add(el);
            items.Children.Add(fl);
        }
        
        public void initChicken()
        {
            RecipeView ar = new RecipeView("Chicken and Rice", "25 min", 2.5);
            RecipeView br = new RecipeView("Chicken Burgers", "40 min", 4);
            RecipeView cr = new RecipeView("Club Sandwiche", "25 min", 4);
            RecipeView dr = new RecipeView("Chicken Curry", "37 min", 4.5);
            ListItem al = new ListItem(dr);
            ListItem bl = new ListItem(myMain.orangeAvoChicken);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem el = new ListItem(ar);
            items.Children.Clear();
            items.Children.Add(al);
            items.Children.Add(bl);
            items.Children.Add(cl);
            items.Children.Add(dl);
            items.Children.Add(el);
        }
    }
}
