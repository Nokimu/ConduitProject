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
    class LoginCreateArticle
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
            IWebElement EmailSignInTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")); EmailSignInTextBox.SendKeys("simic.aleksandar1994@gmail.com");
            IWebElement PasswordSignInTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[3]/input")); PasswordSignInTextBox.SendKeys("Asdf1234");
            IWebElement SubmitSignInButton = driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/button")); SubmitSignInButton.Click();

            IWebElement NewArticleButton = driver.FindElement(By.ClassName("ion-compose")); NewArticleButton.Click();
            IWebElement ArticleTitleTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[1]/input")); ArticleTitleTextBox.SendKeys("Example Title");
            IWebElement DescriptionTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[2]/input")); DescriptionTextBox.SendKeys("This is example article");
            IWebElement ArticleBodyTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[3]/textarea")); ArticleBodyTextBox.SendKeys("Lorem ipsum, lorem ipsum, lorem ipsum, lorem ipsum.");
            IWebElement TagTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/fieldset[4]/input")); TagTextBox.SendKeys("Example tag");
            IWebElement PublishArticleButton = driver.FindElement(By.XPath("/html/body/app-root/app-editor-page/div/div/div/div/form/fieldset/button")); PublishArticleButton.Click();

            IWebElement WriteCommentTextBox = driver.FindElement(By.XPath("/html/body/app-root/app-article-page/div/div[2]/div[3]/div/div/form/fieldset/div[1]/textarea")); WriteCommentTextBox.SendKeys("This is example comment");
            IWebElement SubmitCommentButton = driver.FindElement(By.XPath("/html/body/app-root/app-article-page/div/div[2]/div[3]/div/div/form/fieldset/div[2]/button")); SubmitCommentButton.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}