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
        private RecipeView ar, br, cr, dr;
        public BreakfastCategory(MainWindow aMain)
        {
            initRecipes();
            myMain = aMain;
            InitializeComponent();
            defaultView();

        }
        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }

        void initRecipes()
        {
            ar = new RecipeView("French Toast", "30 min", 5);
            br = new RecipeView("Eggy in a basket", "35 min", 4);
            cr = new RecipeView("English Breakfast", "27 min", 3.5);
            dr = new RecipeView("Steak and Egg", "30 min", 3.5);
        }

        void defaultView()
        {

            Sp1.Children.Clear();

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.pancake);

            Sp1.Children.Add(bl);
            Sp1.Children.Add(cl);
            Sp1.Children.Add(al);
            Sp1.Children.Add(dl);
            Sp1.Children.Add(e1);
        }

        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.pancake);

            Sp1.Children.Clear();

            myMain.sortAlphabetically();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }

        private void TimeSelected(object sender, RoutedEventArgs e)
        {

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.pancake);

            Sp1.Children.Clear();

            myMain.sortTime();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }

        private void RatingSelected(object sender, RoutedEventArgs e)
        {


            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.pancake);
            
            Sp1.Children.Clear();

           myMain.sortRating();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }
    }
      




} // end of namespace
