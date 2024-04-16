using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
            PasteBinMainPage pasteBinMainPage = new PasteBinMainPage(driver, driverWait);

            pasteBinMainPage.Navigate();
            
            pasteBinMainPage.EnterTextInPaste("Hello From WebDriver");
            pasteBinMainPage.ExpandPasteExpirationDropDown();
            pasteBinMainPage.ChoosePasteExpiration10Minutes();
            pasteBinMainPage.EnterNameTitle("helloweb");
            pasteBinMainPage.CreateNewPaste();

            driver.Close();
            driver.Quit();
        }
    }
}