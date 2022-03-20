using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _2Yandex
{
    public class SearchElements
    {
        protected IWebDriver _driver;

        protected SearchElements(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement GetLoginButtonByXPath(string text)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//a[@data-statlog='notifications.mail.logout.enter']")
                        );
                }
                catch
                {
                    Thread.Sleep(1000);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetLoginNameTextFieldByXPath(string text)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//span/input[@type='text']")
                        );
                }
                catch
                {
                    Thread.Sleep(1000);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetLoginButtonSecondById(string id)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.Id("passp:sign-in")
                        );
                }
                catch
                {
                    Thread.Sleep(1000);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetPasswordTextFieldByName(string name)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.Name("passwd")
                        );
                }
                catch
                {
                    Thread.Sleep(1000);
                    attemptCount++;
                }
            }

            return null;
        }
        protected IWebElement GetLoginButtonThirdById(string id)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.Id("passp:sign-in")
                        );
                }
                catch
                {
                    Thread.Sleep(1000);
                    attemptCount++;
                }
            }

            return null;
        }
    }
}
