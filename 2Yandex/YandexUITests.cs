using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace _2Yandex
{
    public class YandexUITests
    {
        private WebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void LogInTest()
        {
            Driver.Url = "https://yandex.by";
            IWebElement loginButtonFirst = Driver.FindElement(By.XPath("//a[@data-statlog='notifications.mail.logout.enter']"));
            loginButtonFirst.Click();
            IWebElement loginNameTextField = Driver.FindElement(By.XPath("//span/input[@type='text']"));
            loginNameTextField.SendKeys("alinutus@yandex.ru");
            IWebElement loginButtonSecond = Driver.FindElement(By.Id("passp:sign-in"));
            loginButtonSecond.Click();
            Thread.Sleep(1000);
            IWebElement passwordTextField = Driver.FindElement(By.Name("passwd"));
            passwordTextField.SendKeys("coherent1");
            IWebElement loginButtonThird = Driver.FindElement(By.Id("passp:sign-in"));
            loginButtonThird.Click();
            Thread.Sleep(1000);


            var accountName = "A";
            var loginElement = Driver.FindElement(By.ClassName("username__first-letter")).Text;
            var message = "Account name has wrong value";
            Assert.AreEqual(accountName, loginElement, message);
        }

    }
}