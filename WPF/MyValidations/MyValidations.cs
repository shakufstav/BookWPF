using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF.MyValidations
{
    public class MyValidations
    {
    }

    public class MaxRule : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (str.Length > 22 && !String.IsNullOrWhiteSpace(str))
            {
                return new ValidationResult(false, "ארוך מידי, אנא הכנס עד 22 תווים");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }

    }

    public class MinRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (str.Length < 2 && !String.IsNullOrWhiteSpace(str))
            {
                return new ValidationResult(false, "קצר מידי, אנא הכנס מעל 2 תווים");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }

    public class NumRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int n;
            string str = value as string;
            bool isNum = Int32.TryParse(str, out n); 
            if (isNum)
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, "אנא הכנס מספר");
            }
        }
    }

    public class EmailRule : ValidationRule
    {
        
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (IsValidEmail(str))
            {
                return ValidationResult.ValidResult;

            }
            else
            {
                return new ValidationResult(false, "אנא הכנס אימייל תקין");

            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }

            catch { return false; }
        }

    }

}
