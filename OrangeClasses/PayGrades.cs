using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.OrangeClasses
{
   public static class PayGrades
    {
        static MyObjects obj = new MyObjects();
        static PayGradeObj obj1 = new PayGradeObj();
        public static void addPayGrade()
        {
            try
            {
                Actions act = new Actions(Properties.driver);
                act.MoveToElement(obj.btnJob).Perform();
                act.MoveToElement(obj1.lnkPayGrades).Click().Perform();
                obj.btnAdd.Click();
                obj1.txtName.SendKeys("ATest");
                obj.btnSave.Click();
                Console.WriteLine("Pay Grade Successfully added");
                Assert.That(Properties.driver.PageSource.Contains("ATest"), Is.EqualTo(true), "ATest Doesn't Exist");
                Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception e)
            {
                IWebElement element = Properties.driver.FindElement(By.XPath("//span[text()='Already exists']"));
                if (element.Displayed == true)
                {
                    Console.WriteLine("Already Exist");
                    obj.btnCancel.Click();

                }
               // Console.WriteLine("ATest Cannot be Added");
                Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        }
        public static void addCurrency()
        {
            try
            {
                obj1.btnAddCurrency.Click();
                obj1.txtCurrency.SendKeys("INR - Indian Rupee");
                obj1.txtMinSalary.SendKeys("10000");
                obj1.txtMaxSalary.SendKeys("100000");
                obj1.btnSaveCurrency.Click();
                Assert.That(Properties.driver.PageSource.Contains("INR - Indian Rupee"), Is.EqualTo(true), "Currency doesn't Exist");
                Assert.That(Properties.driver.PageSource.Contains("ATest"), Is.EqualTo(true), "Currency doesn't Exist");
                obj.btnCancel.Click();
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine("Currency Cannot be added");
            }
        }
        public static void editPayGrades()
        {
            try
            {
            obj1.lnkText.Click();
            obj1.btnAddCurrency.Click();
            obj1.txtCurrency.SendKeys("AUD - Australian Dollar");
            obj1.txtMinSalary.SendKeys("15000");
            obj1.txtMaxSalary.SendKeys("150000");
            obj1.btnSaveCurrency.Click();
            obj.btnSave.Click();
            obj1.txtName.Clear();
            obj1.txtName.SendKeys("BTest");
            obj.btnSave.Click();
            obj.btnCancel.Click();
           Assert.That(Properties.driver.PageSource.Contains("BTest"), Is.EqualTo(true),"BTest Updation failed");
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine("Element Not Found");
            }
            }
        public static void delPayGrades()
        {
            try {

                obj1.chkBTest.Click();
                obj.btnDelete.Click();
                obj.dialogDeletebtn.Click();
                Assert.That(Properties.driver.PageSource.Contains("BTest"), Is.EqualTo(false), " ATest Cannot be Deleted");
                Console.WriteLine("ATest Successfully deleted");

            }
            catch(Exception e)
            {
                Console.WriteLine("ATest cannot be Deleted");
            }
        }
    }
}
