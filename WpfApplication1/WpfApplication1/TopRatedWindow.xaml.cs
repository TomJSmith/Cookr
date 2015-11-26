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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TopRatedWindow.xaml
    /// </summary>
    public partial class TopRatedWindow : Window
    {
        public TopRatedWindow()
        {
            InitializeComponent();
            // this is for the header and the searchbar usercontrol
            SearchBarHeader sh1 =  new SearchBarHeader();
            headerSearchPanel.Children.Add(sh1);

            // this is for the list itme
           ListItem recipeListItem =  new ListItem();
            recipeListItem.recipeName.Content = "whatever";
            trStackPanel.Children.Add(recipeListItem);
            /*
             * so this works. what you need to do is make sure that there are 5 slots for top rated recipes..so
             * you need 5 different stackpanel or grid. id go with a stack panel.
             * so it scrolls 
             * 
             * 
             */

        }// end of TopRatedWindow
    }
}
