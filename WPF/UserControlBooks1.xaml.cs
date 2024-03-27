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
    /// Interaction logic for UserControlBooks1.xaml
    /// </summary>
    public partial class UserControlBooks1 : UserControl
    {
        public UserControlBooks1(Books b)
        {
            InitializeComponent();
            txt.Text = b.BookName;
        }

        private void NavToOneOfUsIsLying(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
