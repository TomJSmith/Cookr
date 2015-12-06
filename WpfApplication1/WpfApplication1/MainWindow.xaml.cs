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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // tabs for main page
        public FavoritesTab favTab;
        public UserControl1 disTab;
        public CatagoriesTab catTab;

        public SearchView search;
        public MainView mainView;

        // search result pages
        public TopRatedView topRated;

        // catagories
        public BreakfastCategory breakFast;
        public LunchCategory lunch;
        public DinnerCategory dinner;
        public DesertCategory desert;
        public SnackCategory snack;
        public DrinkCategory drink;

        // recipes
        public BeefTacosView beefTacos;
        public HawaiianSmoothie hawiianSmoothie;
        public OrangeAvocadoChicken orangeAvoChicken;
        public SpaghettiRecipeView spaghetti;
        public StirFry stirFry;
        public sundaeDessert aSundae;
        public BreakfastPage pancake;

        private Random rnd = new Random();
        UserControl prevView;


        public MainWindow()
        {
            // recipes
            beefTacos = new BeefTacosView();
            hawiianSmoothie = new HawaiianSmoothie();
            orangeAvoChicken = new OrangeAvocadoChicken();
            spaghetti = new SpaghettiRecipeView();
            stirFry = new StirFry();
            aSundae = new sundaeDessert();
            pancake = new BreakfastPage();

            // tabs
            favTab = new FavoritesTab(this);
            disTab = new UserControl1(this);
            catTab = new CatagoriesTab(this);

            search = new SearchView();
            mainView = new MainView();

            // search result
            topRated = new TopRatedView(this);

            // catagories
            breakFast = new BreakfastCategory(this);
            lunch = new LunchCategory(this);
            dinner = new DinnerCategory(this);
            desert = new DesertCategory(this);
            snack = new SnackCategory(this);
            drink = new DrinkCategory(this);

            InitializeComponent();
            contentView.Children.Clear();
            contentView.Children.Add(mainView);
            mainView.MainContent.Children.Clear();
            mainView.MainContent.Children.Add(disTab);
        }

        public void addFav(IRecipe aRecipe)
        {
            favTab.addFavorite(aRecipe);
        }

        public void removeFav(IRecipe aRecipe)
        {
            favTab.removeFavourite(aRecipe);
        }

        public void switchToDiscover()
        {
            mainView.MainContent.Children.Clear();
            mainView.MainContent.Children.Add(disTab);
        }

        public void switchToCatagories()
        {
            mainView.MainContent.Children.Clear();
            mainView.MainContent.Children.Add(catTab);
        }

        public void switchToFavs()
        {
            mainView.MainContent.Children.Clear();
            mainView.MainContent.Children.Add(favTab);
        }

        public void switchSearchView()
        {
            prevView = (UserControl) contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(search);
        }

        public void switchMainView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(mainView);
        }

        public void switchTopRatedView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(topRated);
        }

        public void switchToView(UserControl aUserControl)
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(aUserControl);
        }

        public void switchPrevView()
        {
            UserControl tempPrev = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(prevView);
            prevView = tempPrev;
        }

        public void switchBreakFastView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(breakFast);
        }

        public void switchLunchView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(lunch);
        }
        public void switchDinnerView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(dinner);
        }

        public void switchDesertView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(desert);
        }

        public void switchSnackView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(snack);
        }

        public void switchDrinkView()
        {
            prevView = (UserControl)contentView.Children[0];
            contentView.Children.Clear();
            contentView.Children.Add(drink);  
        }

        public UserControl getRandomRecipe()
        {
            int myCase = rnd.Next(7);
            if (myCase == 0)
            {
                return beefTacos;
            }
            else if (myCase == 1)
            {
                return pancake;
            }
            else if (myCase == 2)
            {
                return hawiianSmoothie;
            }
            else if (myCase == 3)
            {
                return orangeAvoChicken;
            }
            else if (myCase == 4)
            {
                return spaghetti;
            }
            else if (myCase == 5)
            {
                return aSundae;
            }
            else 
            {
                return stirFry;
            }
        }
    }
}
