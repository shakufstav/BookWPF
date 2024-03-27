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
    /// Interaction logic for GanrePage.xaml
    /// </summary>
    public partial class GanrePage : Page
    {
        public GanrePage()
        { 
            InitializeComponent();
            GetAllGenre();

        }
        GenreList gnrLst = new GenreList();
        APIservice api = new APIservice();
        public async Task GetAllGenre()
        {
            gnrLst = await api.GetGenre();
            foreach (var gnr in gnrLst)
            {
                TextBlock t = new TextBlock();
                t.Text = gnr.GenreName;
                t.MouseLeftButtonDown += T_MouseLeftButtonDown; 
                geners.Children.Add(t);
            }
        }

        private void T_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
