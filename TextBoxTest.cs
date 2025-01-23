using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA_Programmimg_Prj
{
    public class TextBoxTest
    {
        IWebDriver Driver;

        [Test]
        public void TestMethod()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();


            IWebElement elementsButton = Driver.FindElement(By.XPath("//h5[text()='Elements']"));
            elementsButton.Click();

            IWebElement textBoxButton = Driver.FindElement(By.XPath("//*[text()='Text Box']"));
            textBoxButton.Click();

            IWebElement firstNameInput = Driver.FindElement(By.Id("userName"));
            firstNameInput.SendKeys("Rox");

            IWebElement emailInput = Driver.FindElement(By.Id("userEmail"));
            emailInput.SendKeys("Rox@mail.com");

            IWebElement currentAddressInput = Driver.FindElement(By.Id("currentAddress"));
            currentAddressInput.SendKeys("Iasington City");

            IWebElement permanentAddressInput = Driver.FindElement(By.Id("permanentAddress"));
            permanentAddressInput.SendKeys("Who-Knows Ville");

            //IJavaScriptExecutor jsExec = (IJavaScriptExecutor)Driver;
            //jsExec.ExecuteScript("window.scrollTo(0,1000");  

            IWebElement submitButton = Driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }
    }
}
