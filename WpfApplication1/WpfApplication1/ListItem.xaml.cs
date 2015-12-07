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
    /// Interaction logic for ListItem.xaml
    /// </summary>
    public partial class ListItem : UserControl
    {
        public UserControl targetUserControl;
        

        public ListItem()
        {
            InitializeComponent();
            IRecipe aRecipe = new RecipeView();
            recipeName.Text = aRecipe.getName();
            time.Content = aRecipe.getTime();
            targetUserControl = (UserControl)aRecipe;
            image.Source = (ImageSource)aRecipe.getImage();
            image1.Source = aRecipe.getRating();

        }

        public ListItem(string aName, string aTime, IRecipe aUserControl)
        {
            InitializeComponent();
            recipeName.Text = aName;
          
            time.Content = aTime;
            targetUserControl = (UserControl)aUserControl;
            image.Source = (ImageSource)aUserControl.getImage();
            image1.Source = aUserControl.getRating();
            

        }


        public ListItem(string name, string time1)
        {
            InitializeComponent();
            IRecipe aRecipe = new RecipeView();
            recipeName.Text = name;
            time.Content = time1;
            targetUserControl = (UserControl)aRecipe;
            image.Source = (ImageSource)aRecipe.getImage();
            image1.Source = aRecipe.getRating();
        }

        public ListItem(IRecipe aRecipe)
        {
            InitializeComponent();
            recipeName.Text = aRecipe.getName();
            time.Content = aRecipe.getTime();
            image.Source = (ImageSource)aRecipe.getImage();
            targetUserControl = (UserControl)aRecipe;
            image1.Source = aRecipe.getRating();

        }


        private void listItemButtonClick(object sender, RoutedEventArgs e)
        {

            MainWindow main = (MainWindow)Window.GetWindow(this);
            if (targetUserControl == null)
                targetUserControl = new RecipeView();
            main.switchToView(this.targetUserControl);

        }

        

    }
}
