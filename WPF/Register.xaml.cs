using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        API_service.APIservice service;
        public Register()
        {
            InitializeComponent();

            service = new API_service.APIservice();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //var x = await service.Register(this.textBox.Text, this.textBox.Text, int.Parse(passwordBox.Password));
            //if (x.IsSuccessStatusCode)
            //{ 
            //    MainPage.user = (User)await x.Content.ReadFromJsonAsync<User>();
            //    NavigationService nav = NavigationService.GetNavigationService(this);
            //    nav.Navigate(new MainPage());
            //}
            //else
            //{
            //    MessageBox.Show(x.ToString());
            //}

            MinRule minRule = new MinRule();
            MaxRule maxRule = new MaxRule();
            EmailRule emailRule = new EmailRule();
            NumRule numRule = new NumRule();
            ValidationResult result1 = minRule.Validate(this.emailTxtBox.Text, null);
            ValidationResult result2 = maxRule.Validate(this.emailTxtBox.Text, null);
            ValidationResult result3 = emailRule.Validate(this.emailTxtBox.Text, null);
            ValidationResult result4 = minRule.Validate(this.userNameTxtBox.Text, null);
            ValidationResult result5 = maxRule.Validate(this.userNameTxtBox.Text, null);
            ValidationResult result6 = maxRule.Validate(this.passwordtext.Text, null);
            ValidationResult result7 = minRule.Validate(this.passwordtext.Text, null);
            ValidationResult result8 = numRule.Validate(this.passwordtext.Text, null);



            string userName = this.userNameTxtBox.Text;
            string emailUser = this.emailTxtBox.Text;
            int passwordUser = 0;//int.Parse(this.passwordBox.Password.ToString());

            User newUser = new User();
            newUser.UserName = userName;
            newUser.Email = emailUser;
            newUser.Ppassword1 = passwordUser;
            int suceed = await service.InsertUser(newUser);

            if(suceed > 0 )
            {
                this.NavigationService.Navigate(new MainPage(newUser));
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)  // fill the correct UName & Password
        {
            this.emailTxtBox.Text = "stav.shakuf@gmail.com";
            this.userNameTxtBox.Text = "סתיו שקוף";
            this.passwordtext.Text = "2812006";
        }


        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Login());
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
