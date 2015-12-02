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
        private string recipe_name;
    
        public int TimeRequired;
        private int time_required;

        private string RTitle
        {
            get { return recipe_name; }

            set
            {
                recipe_name= value;
                recipeName.Content = this.RecipeName; //updating the recipeName in XML with the RecipeName of  Class
            }


        } // end of RTitle


        private int RTime
        {
            get { return time_required; }

            set
            {
                time_required = value;
                time.Content = RTime;
            }
        }// end of RTime





        public ListItem()
        {
            InitializeComponent();
        }
    }
}
