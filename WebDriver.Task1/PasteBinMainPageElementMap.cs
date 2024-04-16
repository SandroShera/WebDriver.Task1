using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task1
{
    internal class PasteBinMainPageElementMap
    {
        private readonly WebDriverWait wait;

        public PasteBinMainPageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        //There is only one element by id="postform-text"
        public IWebElement PasteTextArea
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.Id("postform-text")));
            }
        }

        public IWebElement PasteExpiration
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.Id("select2-postform-expiration-container")));
            }
        }

        public IWebElement PasteExpirationChoice10Minutes
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(@id, \"10M\")]")));
            }
        }

        public IWebElement PasteNameTitleInput
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id=\"postform-name\"]")));
            }
        }

        public IWebElement CreateNewPasteButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button")));
            }
        }
    }
}
