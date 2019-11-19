using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TripAdvisor_testing
{
    public class GlobalVariables
    {
        public static string URL = "https://discoverit.netlify.com/";

        public static string emailPositive = "testwzim@testwzim.com";
        public static string passwordPositive = "Admin123.";

        public static string emailNegative = "a@a.com";
        public static string passwordNegative = "ZleHaslo";

        //rejestracja zmienne - Łukaś
        public static string registerNameCorrect = "Alfred";
        public static string registerSurnameCorrect = "Kamyczek";
        public static string registerEmailCorrect = "alfredkamyczek@wzim.com";
        public static string registerPasswordCorrect = "Abcdefgh1";
        public static string registerEmailIncorrect = "alfredkamyczekwzim.com";
        public static string registerPasswordIncorrect1 = "abcdefghij";
        public static string registerPasswordIncorrect2 = "Abcd1";
    }
}
