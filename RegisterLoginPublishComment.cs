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
    class RegisterLoginPublishComment
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
            IWebElement EmailTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")); EmailTextBox.SendKeys("randomuser" + randomInt + "@gmail.com");
            IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[3]/input")); PasswordTextBox.SendKeys("Asdf123456");
            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/button")); SubmitButton.Click();
            IWebElement SettingsButton = driver.FindElement(By.ClassName("ion-gear-a")); SettingsButton.Click();
            IWebElement LogoutButton = driver.FindElement(By.XPath("/html/body/app-root/app-settings-page/div/div/div/div/button")); LogoutButton.Click();

            IWebElement SignInButton = driver.FindElement(By.XPath("/html/body/app-root/app-layout-header/nav/div/ul/li[2]/a")); SignInButton.Click();
            IWebElement EmailSignInTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")); EmailSignInTextBox.SendKeys("randomuser" + randomInt + "@gmail.com");
            IWebElement PasswordSignInTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[3]/input")); PasswordSignInTextBox.SendKeys("Asdf123456");
            IWebElement SubmitSignInButton = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/button")); SubmitSignInButton.Click();

            IWebElement NewArticleButton = driver.FindElement(By.ClassName("ion-compose")); NewArticleButton.Click();
            IWebElement ArticleTitleTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[1]/input")); ArticleTitleTextBox.SendKeys("Example Title");
            IWebElement DescriptionTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[2]/input")); DescriptionTextBox.SendKeys("This is example article");
            IWebElement ArticleBodyTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[3]/textarea")); ArticleBodyTextBox.SendKeys("Lorem ipsum, lorem ipsum, lorem ipsum, lorem ipsum.");
            IWebElement TagTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[4]/input")); TagTextBox.SendKeys("Example tag");
            IWebElement PublishArticleButton = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/button")); PublishArticleButton.Click();

            IWebElement WriteCommentTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-article-page/div/div[2]/div[3]/div/div/form/fieldset/div[1]/textarea")); WriteCommentTextBox.SendKeys("This is example comment");
            IWebElement PSubmitCommentButton = driver.FindElement(By.XPath("/html/body/app-root/app-article-page/div/div[2]/div[3]/div/div/form/fieldset/div[2]/button")); PSubmitCommentButton.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}