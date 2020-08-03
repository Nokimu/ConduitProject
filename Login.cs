using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConduitProject
{
    class Login
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Dimension\\.nuget\\packages\\selenium.chrome.webdriver\\83.0.0\\driver");
        }

        [Test]
        public void Test()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://localhost:4200/";
            IWebElement SignInButton = driver.FindElement(By.XPath("/html/body/app-root/app-layout-header/nav/div/ul/li[2]/a")); SignInButton.Click();
            IWebElement EmailTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")); EmailTextBox.SendKeys("simic.aleksandar1994@gmail.com");
            IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[3]/input")); PasswordTextBox.SendKeys("Asdf1234");
            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/button")); SubmitButton.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}