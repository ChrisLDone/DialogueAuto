using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml;
using ResetRegression;

namespace Direct.StepDefs
{
    public class CommonComponents
    {
        public static string _title;
        public static string _firstName;
        public static string _lastName;
        public static string _emailAddress;
        public static string _password;
        public static string _PhoneNumber;
        public static string _coverdate;
        public static string _DayOfBirth;
        public static string _MonthOfBirth;
        public static string _YearOfBirth;
        public static string _postCode;
        public static string _policyNumber = "";
        public static string _employmentStatus = "";
        public static string _parttimeoccupation = "";
        public static string _occupation = "";
        public static string _nameoftest;
        public static string _Browser = "Chrome";
        public static string _houseNumber;
        public static string _url = "SIT";
        public static string _userName = "";
        public static string _passWord = "";
        public static string _payeeHouseNumber;
        public static string _payeePostcode;
        public static string _okta = "Off";

        public static IWebDriver driver;

        private static Random random = new Random();
        public static Xpaths xpath_Directory = new Xpaths();

        //Generates a random string
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //Selects the browsers we specify
        public static void BrowserOptions(string Browser)
        {
            if (Browser == "Chrome")
            {
                driver = new ChromeDriver(@"C:\Users\Chris.Done\Desktop\");
            }
            else if (Browser == "Firefox")
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\chris.Done\Desktop");
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                driver = new FirefoxDriver(service);
            }
            else
            {
                driver = new InternetExplorerDriver(@"C:\Users\Chris.Done\Desktop\IEDriver\");
            }
        }
        //Selects the environment we specify
        public static void EnvironmentOptions(string Environment)
        {
            if (Environment == "PreProd")
            {
                driver.Url = "https://wwwpre.providentinsurance.co.uk";
                driver.FindElement(By.XPath(xpath_Directory.EnterUsername())).SendKeys(_userName);
                driver.FindElement(By.XPath(xpath_Directory.EnterPassword())).SendKeys(_passWord);
                driver.FindElement(By.XPath(xpath_Directory.LogonButton())).Click();
                //WaitForElementToBeClickable(xpath_Directory.GetQuoteButton());
            }
            else if (Environment == "SITB")
            {
                driver.Url = "http://wwwsitb.coveainsurance.co.uk";
            }
            else
            {
                driver.Url = "http://wwwtest.providentinsurance.co.uk";
            }
        }

        public static void logwriter()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"./SIT Regression.txt", true))
            {
                file.WriteLine("####################Name of test:   " + _nameoftest + "####################");
                file.WriteLine("Firstname:       " + _firstName);
                file.WriteLine("Lastname:        " + _lastName);
                file.WriteLine("DayOfBirth:      " + _DayOfBirth);
                file.WriteLine("MonthOfBirth:    " + _MonthOfBirth);
                file.WriteLine("YearOfBirth:     " + _YearOfBirth);
                file.WriteLine("PostCode:        " + _postCode);
                file.WriteLine("Email:           " + _emailAddress);
                file.WriteLine("Password:        " + _password);
                file.WriteLine("Phonenumber:     " + _PhoneNumber);
                file.WriteLine("Occupation:      " + _occupation);
                file.WriteLine("Parttime occupation:   " + _parttimeoccupation);
                file.WriteLine("The policy number for this test is  :" + _policyNumber);
         }
        }

        public static void TakeScreenshot()
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string fp = "C:_" + "PreProd Regression" + "_" + DateTime.Now.ToString("dd_YYYY_hh_mm_ss_tt") + ".Jpeg";
                ss.SaveAsFile(fp, ScreenshotImageFormat.Jpeg);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void WaitForElementToBeClickable(string ElementToBeClickable)
        {
            try
            {
                Boolean elementShown = driver.FindElement(By.XPath(ElementToBeClickable)).Displayed;
                driver.FindElement(By.XPath(ElementToBeClickable)).Click();
            }
            catch (Exception e)
            {
                Thread.Sleep(1000);
                WaitForElementToBeClickable(ElementToBeClickable);
            }
            return;
        }

    }
}
