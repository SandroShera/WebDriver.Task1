using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task1
{
    internal class PasteBinMainPage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;
        private readonly string url = @"https://pastebin.com/";

        public PasteBinMainPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
        }

        protected PasteBinMainPageElementMap Map
        {
            get
            {
                return new(this.wait);
            }
        }

        public void Navigate()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void EnterTextInPaste(string text)
        {
            this.Map.PasteTextArea.Clear();
            this.Map.PasteTextArea.SendKeys(text);
        }

        public void ExpandPasteExpirationDropDown()
        {
            this.Map.PasteExpiration.Click();
        }

        public void ChoosePasteExpiration10Minutes()
        {
            this.Map.PasteExpirationChoice10Minutes.Click();
        }

        public void EnterNameTitle(string text)
        {
            this.Map.PasteNameTitleInput.Clear();
            this.Map.PasteNameTitleInput.SendKeys(text);
        }

        public void CreateNewPaste()
        {
            this.Map.CreateNewPasteButton.Click();
        }
    }
}
