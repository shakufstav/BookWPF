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
    /// Interaction logic for One_of_us_is_lying.xaml
    /// </summary>
    public partial class One_of_us_is_lying : Page
    {
        GenreList gnrLst = new GenreList();
        APIservice api= new APIservice();
        private async void getAllGnr()
        {
            gnrLst=await api.GetGenre();
        }
        public One_of_us_is_lying()
        {
            InitializeComponent();
            getAllGnr();
            foreach(var gnr in gnrLst) 
            {
                TextBlock t= new TextBlock();
                t.Text = gnr.GenreName;
                t.MouseLeftButtonDown += NavToGenrePage; 
                pageG.Children.Add(t);
            }
        }

        private void NavToGenrePage(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
