using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace _2Yandex
{
    public class Tests
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LogIn()
        {
            driver.Url = "https://yandex.by";
            IWebElement loginButtonFirst = driver.FindElement(By.XPath("//a[@data-statlog='notifications.mail.logout.enter']"));
            loginButtonFirst.Click();
            IWebElement loginNameTextField = driver.FindElement(By.XPath("//span/input[@type='text']"));
            loginNameTextField.SendKeys("mastermister123");
            IWebElement loginButtonSecond = driver.FindElement(By.Id("passp:sign-in"));
            loginButtonSecond.Click();
            Thread.Sleep(1000);
            IWebElement passwordTextField = driver.FindElement(By.Name("passwd"));
            passwordTextField.SendKeys("mastermister1231");
            IWebElement loginButtonThird = driver.FindElement(By.Id("passp:sign-in"));
            loginButtonThird.Click();
            Thread.Sleep(1000);
            
            var accountName = "m";
            var loginElement = driver.FindElement(By.ClassName("username__first-letter")).Text;
            Assert.AreEqual(accountName, loginElement);
        }

    }
}