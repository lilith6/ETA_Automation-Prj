using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ETA_Programmimg_Prj
{
    internal class PracticeForm
    {
        IWebDriver Driver;

        [Test]
        public void TestMethod()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            //IJavaScriptExecutor jsExec = (IJavaScriptExecutor)Driver;
            //jsExec.ExecuteScript("window.scrollTo(0,1000");

            IWebElement formsButton = Driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
           formsButton.Click();

            IWebElement practiceFormButton = Driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceFormButton.Click();


            IWebElement genderMale = Driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement genderFemale = Driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
            IWebElement genderOther = Driver.FindElement(By.XPath("//label[@for='gender-radio-3']"));

            String gender = "Male";

            switch (gender.ToLower())
            {
                case "male": genderMale.Click();
                    break;
                case "female": genderFemale.Click();    
                    break;
                default: genderOther.Click(); break;
            }

            IWebElement subjectsInput = Driver.FindElement(By.XPath("//input[@id='subjectsInput']"));
            subjectsInput.SendKeys("english");
            subjectsInput.SendKeys(Keys.Enter);
            subjectsInput.SendKeys("C");
            subjectsInput.SendKeys(Keys.ArrowDown);
            subjectsInput.SendKeys(Keys.ArrowDown);
            subjectsInput.SendKeys(Keys.Enter);
        }
    }
}
