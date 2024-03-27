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

namespace WPF
{
    /// <summary>
    /// Interaction logic for LatelyBooks.xaml
    /// </summary>
    public partial class LatelyBooks : Page
    {
        public LatelyBooks()
        {
            InitializeComponent();
        }

        private void NavToOneOfUsIsLying(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new One_of_us_is_lying ());
        }

        private void NavToTwistedLove(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new TwistedLove());
        }

        private void NavToTheSummerITurndPretty(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new TheSummerITurndPretty());
        }
    }
}
