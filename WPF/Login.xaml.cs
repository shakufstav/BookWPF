using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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
using API_service;
using Model;
using WPF.MyValidations;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        APIservice  service;
        private NavigationService navSrv;
        public Login()
        {
            InitializeComponent();
            this.Loaded += Login_Loaded;

            DataContext = new ValidationConnection();

            service = new APIservice();
        }

        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            this.navSrv = this.NavigationService;
            this.navSrv.Navigating += NavSrv_Navigating; ;
        }

        private void NavSrv_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
                e.Cancel = true;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            MinRule minRule = new MinRule();
            MaxRule maxRule = new MaxRule();
            EmailRule emailRule = new EmailRule();
            NumRule numRule = new NumRule();
            ValidationResult result1 = minRule.Validate(this.textBox.Text, null);
            ValidationResult result2 = maxRule.Validate(this.textBox.Text, null);
            ValidationResult result3 = emailRule.Validate(this.textBox.Text, null);
            ValidationResult result4 = minRule.Validate(this.textBox_Copy4.Text, null);
            ValidationResult result5 = maxRule.Validate(this.textBox_Copy4.Text, null);
            ValidationResult result6 = maxRule.Validate(this.passwordTxtBox.Text, null);
            ValidationResult result7 = minRule.Validate(this.passwordTxtBox.Text, null);
            ValidationResult result8 = numRule.Validate(this.passwordTxtBox.Text, null);

            //


            if (this.passwordTxtBox.Text != null && this.textBox_Copy4.Text != null && textBox.Text != null && result1.IsValid && result2.IsValid && result3.IsValid && result4.IsValid && result5.IsValid && result6.IsValid && result7.IsValid && result8.IsValid)
            {


                var x = await service.Login(this.textBox.Text, this.textBox_Copy4.Text, int.Parse(passwordTxtBox.Text));
                if (x.IsSuccessStatusCode)
                { MainPage.User = (User)await x.Content.ReadFromJsonAsync<User>(); }

                if (MainPage.User == null)
                {

                    textBlock.Visibility = Visibility.Visible;
                    textBlock.Text = "שם משתמש או הסיסמא לא נכונים, נסה שנית";
                }
                else
                {
                    NavigationService nav = NavigationService.GetNavigationService(this);
                    nav.Navigate(new MainPage(MainPage.user));

                }
                //UserList users = await service.GetUser();
                //string user = this.textBox
            }
            else
            {
                MessageBox.Show("הנתונים שהוכנסו הינם שגויים");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)  // fill the correct UName & Password
        {
            this.textBox_Copy4.Text = "סתיו שקוף";
            this.textBox.Text = "stav.shakuf@gmail.com";
            this.passwordTxtBox.Text = "2812006";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Register());
        }

        private void textBox_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

