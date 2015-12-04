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
        public TopRatedView()
        {
            InitializeComponent();
            defaultView();



        }


        private void defaultView()
        {
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            BeefTacosView beefTacos = new BeefTacosView();
            HawaiianSmoothie hSmoothie = new HawaiianSmoothie();
            OrangeAvocadoChicken orangeChicken = new OrangeAvocadoChicken();
            StirFry stirFry = new StirFry();
            Sp1.Children.Clear();


            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", hSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange and Avocado Thai Grilled \n Chicken Thighs", "25 Mins",
                orangeChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", stirFry);
            Sp1.Children.Add(item5ListItem);

        }

        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            BeefTacosView beefTacos = new BeefTacosView();
            HawaiianSmoothie hSmoothie = new HawaiianSmoothie();
            OrangeAvocadoChicken orangeChicken = new OrangeAvocadoChicken();
            StirFry stirFry = new StirFry();
            Sp1.Children.Clear();

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", stirFry);
            Sp1.Children.Add(item5ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", hSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange and Avocado Thai Grilled \n Chicken Thighs", "25 Mins",
                orangeChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

        }



        private void TimeSelected(object sender, RoutedEventArgs e)
        {
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            BeefTacosView beefTacos = new BeefTacosView();
            HawaiianSmoothie hSmoothie = new HawaiianSmoothie();
            OrangeAvocadoChicken orangeChicken = new OrangeAvocadoChicken();
            StirFry stirFry = new StirFry();
            Sp1.Children.Clear();

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", hSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item4ListItem = new ListItem("Orange and Avocado Thai Grilled \n Chicken Thighs", "25 Mins",
                orangeChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", stirFry);
            Sp1.Children.Add(item5ListItem);

        }

        private void RatingSelected(object sender, RoutedEventArgs e)
        {

            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            BeefTacosView beefTacos = new BeefTacosView();
            HawaiianSmoothie hSmoothie = new HawaiianSmoothie();
            OrangeAvocadoChicken orangeChicken = new OrangeAvocadoChicken();
            StirFry stirFry = new StirFry();
            Sp1.Children.Clear();


            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", beefTacos);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", hSmoothie);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange and Avocado Thai Grilled \n Chicken Thighs", "25 Mins",
                orangeChicken);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", stirFry);
            Sp1.Children.Add(item5ListItem);


        }
    }

}