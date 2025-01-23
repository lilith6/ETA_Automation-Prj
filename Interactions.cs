using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace ETA_Programmimg_Prj
{
    internal class Interactions
    {
        IWebDriver Driver;

        public void PrintElementsList(List<IWebElement> myList )
        {
            Console.WriteLine();
            foreach (IWebElement element in myList)
            {
                Console.WriteLine(element.Text);
            }
        }

        [Test]
        public void Sortable()
        {
            Driver = new ChromeDriver();
            Actions action = new Actions(Driver);
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IWebElement interactionsElement = Driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsElement.Click();

            List<IWebElement> interactionsMenu = new List<IWebElement>(
               Driver.FindElements(By.XPath("//div[@class='element-list collapse show']//ul//li"))
            );

            //foreach (IWebElement menuItem in interactionsMenu)
            //{
            //    if (menuItem.Text == "Sortable")
            //    {
            //        menuItem.Click();
            //    }
            //}

            interactionsMenu[0].Click();

            List<IWebElement> sortableList = new List<IWebElement> (
                Driver.FindElements(By.XPath("//div[@class='vertical-list-container mt-4']//div"))
                );


            PrintElementsList( sortableList );

            action.DragAndDrop(sortableList[0], sortableList[4]).Build().Perform();

            PrintElementsList(sortableList);


        }
    }
}
