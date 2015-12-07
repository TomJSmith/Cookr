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
            ar = new RecipeView("Home made Coke", "30 min", 5);
            br = new RecipeView("Jack and Coke", "03 min", 5);
            cr = new RecipeView("Black Tooth Grin", "03 min", 5);
            dr = new RecipeView("AMF", "04 min", 5);
        }
        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }
        public void defaultView()
        {
            
            Sp1.Children.Clear();



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

        private void AlphabeticalSort(object sender, RoutedEventArgs e)
        {


            ListItem al = new ListItem(ar);
            ListItem bl = new ListItem(dr);
            ListItem cl = new ListItem(br);
            ListItem dl = new ListItem(cr);
            ListItem e1 = new ListItem(myMain.hawiianSmoothie);


            Sp1.Children.Clear();

         

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }

        }



       
    }




           
       
           
       
    }

