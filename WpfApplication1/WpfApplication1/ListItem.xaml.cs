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

        public string RecipeName;
        // dont use this anymore
        public Window TargetWindow;
        // use this userControl to store where the button links to
        public UserControl targetUserControl;
        public int TimeRequired;
        
        public ListItem(string aName, string aTime, UserControl aUserControl)
        {
            InitializeComponent();
            recipeName.Content = aName;
            time.Content = aTime;
            targetUserControl = aUserControl;
        }

        public ListItem(string name, string time1, Window Twindow)
        {
            InitializeComponent();
            recipeName.Content = name;
            time.Content = time1;
            TargetWindow = Twindow;

        }

        public ListItem(string name, string time1)
        {
            InitializeComponent();
            recipeName.Content = name;
            time.Content = time1;
        }

        private string RTitle
        {
            get
            {
                return RecipeName;
            }

            set
            {
                RecipeName = value;
                recipeName.Content = this.RecipeName; //updating the recipeName in XML with the RecipeName of  Class
            }


        } // end of RTitle


        private int RTime
        {
            get
            {
                return TimeRequired;
            }

            set
            {
                TimeRequired = value;
                time.Content = RTime;
            }
        }// end of RTime

        private Window RWindow
        {
            get
            {
                return TargetWindow;
            }

            set
            {
                TargetWindow = value;
                
            }

        }

        public ListItem()
        {
            InitializeComponent();
        }

        private void listItemButtonClick(object sender, RoutedEventArgs e)
        {
            //we are using user controls now, no more closing and showing windows
            //Window.GetWindow(this).Close();
            //TargetWindow.Show();
        }

        // event handler for clicking on a list item
        private void ListItemClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);
            if (targetUserControl == null)
                targetUserControl = new RecipeView();
            main.switchToView(targetUserControl);
        }
    }
}
