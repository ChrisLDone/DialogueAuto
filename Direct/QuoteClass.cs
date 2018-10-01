
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Windows;


namespace ResetRegression
{
    public class Quote1
    {
        public static string QuoteID
        {
            get { return "(//*[@id='panelQuoteSummary']/div/p[1]/text()[2]"; }
            set { QuoteID = value; }
        }
    }
}

    



