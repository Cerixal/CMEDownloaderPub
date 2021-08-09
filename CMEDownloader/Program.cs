using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CMEDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetPrice();
            GetAll();
        }

        public static void GetPrice()
        {

            // Initialise Driver 

            ChromeOptions Options = new();
            //Options.AddArguments("--headless", "--disable-gpu", "--screensize=1920-1080", "--disable-software-rasterizer", "--no-sandbox");

            var Driver = new ChromeDriver(Options);

            // Go to Website 
            var ConnectionString = ($"https://www.cmegroup.com/markets/energy/refined-products/european-gasoil-ice-futures.html");
            Driver.Navigate().GoToUrl(ConnectionString);

            Driver.FindElement(By.Id("pardotCookieButton")).Click();
            Driver.FindElement(By.ClassName("load-all")).Click();
            for (int i = 1; i < 79; i++)
            {
                var result = Driver.FindElements(By.XPath($"//*[@id='productTabData']/div/div/div/div/div/div/div[5]/div/div/div/div[1]/div/table/tbody/tr[{i}]/td[6]"));
                foreach (var node in result)
                {
                    Console.WriteLine(node.Text);
                }
            }
        }
        public static void GetAll()
        {
            // Initialise Driver 

            ChromeOptions Options = new();
            //Options.AddArguments("--headless", "--disable-gpu", "--screensize=1920-1080", "--disable-software-rasterizer", "--no-sandbox");

            var Driver = new ChromeDriver(Options);

            // Go to Website 
            var ConnectionString = ($"https://www.cmegroup.com/markets/energy/refined-products/european-gasoil-ice-futures.html");
            Driver.Navigate().GoToUrl(ConnectionString);

            Driver.FindElement(By.Id("pardotCookieButton")).Click();
            Driver.FindElement(By.ClassName("load-all")).Click();
            for (int i = 1; i < 79; i++)
            {
                var result = Driver.FindElements(By.ClassName("table-cell"));
                foreach (var node in result)
                {
                    Console.WriteLine(node.Text);
                }
            }
        }
    }
}