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
    /// Interaction logic for DrinkCategory.xaml
    /// </summary>
    public partial class DrinkCategory : UserControl
    {
        private MainWindow myMain;
        private RecipeView ar, br, cr, dr;

        public DrinkCategory(MainWindow aMain)
        {
            initRecipes();
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }

        void initRecipes()
        {
            ar = new RecipeView("Home made Orange Juice", "30 min", 5);
            br = new RecipeView("Jack and Coke", "03 min", 4);
            cr = new RecipeView("Black Tooth Grin", "03 min", 4);
            dr = new RecipeView("AMF", "04 min", 2.5);
        }

        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow) Window.GetWindow(this);
            mainWindow.switchPrevView();
        }

        public void defaultView()
        {

            Sp1.Children.Clear();



            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(br);
            ListItem cl = new ListItem(cr);
            ListItem dl = new ListItem(dr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);



            Sp1.Children.Add(al);
            Sp1.Children.Add(bl);
            Sp1.Children.Add(e1);
            Sp1.Children.Add(cl);
            Sp1.Children.Add(dl);



        }

        private void AlphabeticalSort(object sender, RoutedEventArgs e)
        {


        


            Sp1.Children.Clear();

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

            myMain.sortAlphabetically();
            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }

        }

        private void TimeSelected(object sender, RoutedEventArgs e)
        {




            Sp1.Children.Clear();

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

            myMain.sortTime();
            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }



        }

        private void RatingSort(object sender, RoutedEventArgs e)
        {




            Sp1.Children.Clear();

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

            myMain.sortRating();
            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }

        private void TimeSort(object sender, RoutedEventArgs e)
        {




            Sp1.Children.Clear();

            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

            myMain.sortTime();
            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }








    }

}