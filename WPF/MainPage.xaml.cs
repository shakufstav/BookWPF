using Model;
using API_service;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static User user = new User();
        public MainPage(Model.User user)
        {
            InitializeComponent();
            txt.Text = " שלום" + " " + user.UserName ;

        }

        public static User User { get => user; set => user = value; }

 
        private void recommendBookButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new RecommendBook());
        }

        private void latelyBookButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LatelyBooks());
        }

        private void digitalBookButton_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void weekBook_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void genreBookButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new GanrePage());
        }

        private void movieBookButton_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void privateArea_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
