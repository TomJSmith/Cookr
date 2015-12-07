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
    /// Interaction logic for DesertCategory.xaml
    /// </summary>
    public partial class DesertCategory : UserControl
    {
        private MainWindow myMain;
        public DesertCategory(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }

        void defaultView()
        {
          //  Sp1.Children.Clear();
          //  ListItem item1 =  new ListItem(myMain.aSundae.getName(),myMain.aSundae.getTime(),myMain.aSundae);
          //  Sp1.Children.Add(item1);

            Sp1.Children.Clear();


            RecipeView ar = new RecipeView("Chocolate Rush", "03 min", 5);
            RecipeView br = new RecipeView("Diabetes in a bowl", "05 min", 4);
            RecipeView cr = new RecipeView("Sugar Rush", "07 min", 3.5);
            RecipeView dr = new RecipeView("Monster and IceCream Float", "09 min", 3.5);

            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.aSundae);



            Sp1.Children.Add(bl);
            Sp1.Children.Add(cl);
            Sp1.Children.Add(al);
            Sp1.Children.Add(dl);
            Sp1.Children.Add(e1);


        }

        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {
            RecipeView ar = new RecipeView("Chocolate Rush", "03 min", 5);
            RecipeView br = new RecipeView("Diabetes in a bowl", "05 min", 4);
            RecipeView cr = new RecipeView("Sugar Rush", "07 min", 3.5);
            RecipeView dr = new RecipeView("Monster and IceCream Float", "09 min", 3.5);

           


            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.aSundae);



            Sp1.Children.Clear();

            myMain.sortAlphabetically();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }

        }

        private void TimeSelected(object sender, RoutedEventArgs e)
        {
            RecipeView ar = new RecipeView("Chocolate Rush", "03 min", 5);
            RecipeView br = new RecipeView("Diabetes in a bowl", "05 min", 4);
            RecipeView cr = new RecipeView("Sugar Rush", "07 min", 3.5);
            RecipeView dr = new RecipeView("Monster and IceCream Float", "09 min", 3.5);




            myMain.itemOfLists[0] = new ListItem(ar);
            myMain.itemOfLists[1] = new ListItem(dr);
            myMain.itemOfLists[2] = new ListItem(br);
            myMain.itemOfLists[3] = new ListItem(cr);
            myMain.itemOfLists[4] = new ListItem(myMain.aSundae);



            Sp1.Children.Clear();

            myMain.sortTime();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }
        }
    }
}
