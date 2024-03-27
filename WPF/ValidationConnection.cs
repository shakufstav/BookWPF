using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class ValidationConnection : INotifyPropertyChanged


    {

        /// <summary>
        /// /////////////////////////////////////////////////login
        /// </summary>
        private string txtEmail;
        private string txtUserName;
        private string txtPass;

        public string TxtEmail
        {
            get { return txtEmail; }
            set
            {
                txtEmail = value;
                OnPropertyChanged(nameof(TxtEmail));
            }
        }

        public string TxtUserName
        {
            get { return txtUserName; }
            set
            {
                txtUserName = value;
                OnPropertyChanged(nameof(TxtUserName));
            }
        }

        public string TxtPass
        {
            get { return txtPass; }
            set
            {
                txtPass = value;
                OnPropertyChanged(nameof(TxtPass));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////register
        ///להעתיק את על הךלוגין לכאן ולשנות שמות של משתנים
        ///ובעיצוב להוסיף את הדברים ובמסך מאחוריי העיצוב להוסיף את השמונה

        private string txtEmailReg;
        private string txtUserNameReg;
        private string txtPassReg;

        public string TxtEmailReg
        {
            get { return txtEmailReg; }
            set
            {
                txtEmailReg = value;
                OnPropertyChanged(nameof(TxtEmailReg));
            }
        }

        public string TxtUserNameReg
        {
            get { return txtUserNameReg; }
            set
            {
                txtUserNameReg = value;
                OnPropertyChanged(nameof(TxtUserNameReg));
            }
        }

        public string TxtPassReg
        {
            get { return txtPassReg; }
            set
            {
                txtPassReg = value;
                OnPropertyChanged(nameof(TxtPassReg));
            }
        }



        
    }
}
