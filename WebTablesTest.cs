using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA_Programmimg_Prj
{
    public class WebTablesTest
    {
        IWebDriver Driver;

        [Test]
        public void TestMethod()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IWebElement elementsButton = Driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
            elementsButton.Click();

            IWebElement webTablesButton = Driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            webTablesButton.Click();

            IWebElement addButton = Driver.FindElement(By.Id("addNewRecordButton"));
            addButton.Click();

            IWebElement popupFirstName = Driver.FindElement(By.Id("firstName"));
            IWebElement popupLastName = Driver.FindElement(By.Id("lastName"));
            IWebElement popupUserEmail = Driver.FindElement(By.Id("userEmail"));
            IWebElement popupAge = Driver.FindElement(By.Id("age"));
            IWebElement popupSalary = Driver.FindElement(By.Id("salary"));
            IWebElement popupDepartment = Driver.FindElement(By.Id("department"));

            popupFirstName.SendKeys("Ioana");
            popupLastName.SendKeys("Gigica");
            popupUserEmail.SendKeys("IG@gmail.com");
            popupAge.SendKeys("78");
            popupSalary.SendKeys("56789");
            popupDepartment.SendKeys("Gardening");

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

            IWebElement submitButton = Driver.FindElement(By.Id("submit"));
            jse.ExecuteScript("arguments[0].click();", submitButton);

            //submitButton.Submit();

            IWebElement newRowWebTable = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));

            Console.WriteLine(newRowWebTable.Text);

            //Assert.True(newRowWebTable.Text.Contains("Ioana"));
            //Assert.True(newRowWebTable.Text.Contains("Gigica"));
            //Assert.True(newRowWebTable.Text.Contains("78"));
            //Assert.True(newRowWebTable.Text.Contains("IG@gmail.com"));
            //Assert.True(newRowWebTable.Text.Contains("56789"));
            //Assert.True(newRowWebTable.Text.Contains("Gardening"));

            IWebElement firstName = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
            IWebElement lastName = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
            IWebElement age = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
            IWebElement email = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
            IWebElement salary = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
            IWebElement department = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

            Assert.That(firstName.Text.Equals("Alexandrina"));
            Assert.That(lastName.Text.Equals("Gigica"));
            Assert.That(age.Text.Equals("78"));
            Assert.That(email.Text.Equals("IG@gmail.com"));
            Assert.That(salary.Text.Equals("56789"));
            Assert.That(department.Text.Equals("Gardening"));
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    if (Driver != null)
        //    {
        //        Driver.Dispose();
        //        Driver.Quit();
        //    }
        //}
    }
}