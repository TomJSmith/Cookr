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
    /// Interaction logic for SnackCategory.xaml
    /// </summary>
    public partial class SnackCategory : UserControl
    {
        private MainWindow myMain;
        public SnackCategory(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
        }
    }
}
