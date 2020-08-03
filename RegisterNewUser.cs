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
    class RegisterNewUser
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
            IWebElement SignUpButton = driver.FindElement(By.XPath("/html/body/app-root/app-layout-header/nav/div/ul/li[3]/a")); SignUpButton.Click();
            Random random = new Random();
            int i = random.Next(0, 100);
            IWebElement UsernameTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[1]/input")); UsernameTextBox.SendKeys("RandomUser" + i);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            IWebElement EmailTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")); EmailTextBox.SendKeys("User" + randomInt + "@gmail.com");
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