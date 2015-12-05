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
        public FavoritesTab favTab;
        public UserControl1 disTab;
        public CatagoriesTab catTab;
        public SearchView search;
        public MainView mainView;
        public TopRatedView topRated;
        public BreakfastCategory breakFast;
        public LunchCategory lunch;
        public DinnerCategory dinner;
        public DesertCategory desert;
        public SnackCategory snack;
        public DrinkCategory drink;


        UserControl prevView;


        public MainWindow()
        {
            favTab = new FavoritesTab(this);
            disTab = new UserControl1(this);
            catTab = new CatagoriesTab(this);
            search = new SearchView();
            mainView = new MainView();
            topRated = new TopRatedView();
            InitializeComponent();
            contentView.Children.Clear();
            contentView.Children.Add(mainView);
            mainView.MainContent.Children.Clear();
            mainView.MainContent.Children.Add(disTab);
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
    }
}
