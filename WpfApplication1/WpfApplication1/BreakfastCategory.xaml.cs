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



           

            RecipeView ar = new RecipeView("Cheese Omlet", "30 min", 5);
            RecipeView br = new RecipeView("Eggy in a basket", "35 min", 4);
            RecipeView cr = new RecipeView("English Breakfast", "27 min", 3.5);
        
            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(myMain.pancake);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);


            Sp1.Children.Add(bl);
            Sp1.Children.Add(cl);
            Sp1.Children.Add(al);
            Sp1.Children.Add(dl);


        }
    
    
    }// end of BreakfastCategory


} // end of namespace
