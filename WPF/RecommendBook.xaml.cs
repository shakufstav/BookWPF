using API_service;
using Model;
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
    /// Interaction logic for RecommendBook.xaml
    /// </summary>
    public partial class RecommendBook : Page
    {
        public RecommendBook()
        {
            InitializeComponent();
            GetAllBooks();
        }

        public async Task GetAllBooks()
        {
            APIservice api = new APIservice();
            BooksList bookLst = await api.GetBooks();
            UserControlBooks1 userControlBooks;
            foreach (Books b in bookLst)
            {
                userControlBooks = new UserControlBooks1(b);
            }
        }

        private void NavToTheSelection(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new theSelectionBook());
        }

        private void NavToFourthWing(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new FourthWingBook());
        }

        private void NavToItEndsWithUs(object sender, MouseButtonEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ItEndsWithUsBook());
        }
    }
}
