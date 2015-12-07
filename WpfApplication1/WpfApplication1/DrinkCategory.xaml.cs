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
        public DrinkCategory(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }

        public void defaultView()
        {
            
            Sp1.Children.Clear();


            RecipeView ar = new RecipeView("Jack And Coke", "03 min", 5);
            RecipeView br = new RecipeView("Fruit Smoothie", "09 min", 4);
            RecipeView cr = new RecipeView("A.M.F", "05 min", 3.5);
            RecipeView dr = new RecipeView("White Russian", "03 min", 3.5);

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);
            
       


          

            Sp1.Children.Add(bl);
            Sp1.Children.Add(cl);
            Sp1.Children.Add(al);
            Sp1.Children.Add(dl);
            Sp1.Children.Add(e1);



        }
        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {


            RecipeView ar = new RecipeView("Jack And Coke", "03 min", 5);
            RecipeView br = new RecipeView("Fruit Smoothie", "09 min", 4);
            RecipeView cr = new RecipeView("A.M.F", "05 min", 3.5);
            RecipeView dr = new RecipeView("White Russian", "03 min", 3.5);

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);

            Sp1.Children.Clear();

            myMain.sortAlphabetically();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }

        }

        private void RatingSelected(object sender, RoutedEventArgs e)
        {
             RecipeView ar = new RecipeView("Jack And Coke", "03 min", 5);
            RecipeView br = new RecipeView("Fruit Smoothie", "09 min", 4);
            RecipeView cr = new RecipeView("A.M.F", "05 min", 3.5);
            RecipeView dr = new RecipeView("White Russian", "03 min", 3.5);

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);

            Sp1.Children.Clear();

            myMain.sortRating();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }


        }

        private void TimeSelected(object sender, RoutedEventArgs e)
       {
             RecipeView ar = new RecipeView("Jack And Coke", "03 min", 5);
            RecipeView br = new RecipeView("Fruit Smoothie", "09 min", 4);
            RecipeView cr = new RecipeView("A.M.F", "05 min", 3.5);
            RecipeView dr = new RecipeView("White Russian", "03 min", 3.5);

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);

            Sp1.Children.Clear();

            myMain.sortTime();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }


        }




           
       
    }
}
