using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OrangeHRM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OrangeHRM.OrangeClasses
{
    public static class MyMethods 
    {
        static MyObjects obj = new MyObjects();
        private static string userName = "Admin";
        private static string password = "admin123";


        public static void initialize() 

            {
              Properties.driver = new ChromeDriver();
              Properties.driver.Navigate().GoToUrl(TestContext.Parameters.Get("Initialization"));
              Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
              Console.WriteLine("OrangeHRM page opened");
            }
        
        public static void LoginMethod()
            {
                obj.txtUserName.SendKeys(userName);
                obj.txtPswd.SendKeys(password);
                obj.btnLogin.Click();
                Console.WriteLine("Page Successfully Opened");
                Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            public static void AdminMethod()
            {
                Actions act = new Actions(Properties.driver);
                act.MoveToElement(obj.btnAdmin).Perform();
               /* act.MoveToElement(obj.btnJob).Perform();
                act.MoveToElement(obj.btnJobTitle).Click().Perform();*/


            }
        public static void AddMethod()
            {   
                try
                {
                Actions act = new Actions(Properties.driver);
                act.MoveToElement(obj.btnJob).Perform();
                act.MoveToElement(obj.btnJobTitle).Click().Perform();
                obj.btnAdd.Click();
                    obj.txtJobTitle.SendKeys("ATest");
                    obj.txtJobDesc.SendKeys("ATest Description");
                //obj.btnChooseFile.Click();
                //var elem = Properties.driver.SwitchTo().Alert();
                //obj.btnChooseFile.SendKeys("Eod status.xlsx");
                //elem.Accept();
                obj.txtNote.SendKeys("ATest Notes");
                obj.btnSave.Click();
                IWebElement element = Properties.driver.FindElement(By.XPath("//span[text()='Already exists']"));
                if (element.Displayed == true)
                {
                    Console.WriteLine("Already Exist");
                    obj.btnCancel.Click();
                    Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    obj.btnAdd.Click();
                    obj.txtJobTitle.SendKeys("BTest");
                    obj.txtJobDesc.SendKeys("BTest Description");
                    obj.btnSave.Click();
                    Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    Assert.That(Properties.driver.PageSource.Contains("BTest"), Is.EqualTo(true),
                                               "The test doesn't Exist");
                }
                Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    Assert.That(Properties.driver.PageSource.Contains("ATest"), Is.EqualTo(true),
                                                  "The test doesn't Exist");
                
                //Console.WriteLine("ATest Successfully Added");
            }
                catch (Exception e)
                {
                Console.WriteLine("Something went wrong");
                  }   
                
            }
           
    
        public static void deleteMethod()
        {
            try
            {
                if (obj.selTest.Displayed)
                {
                    obj.selTest.Click();
                    obj.btnDelete.Click();
                    obj.dialogDeletebtn.Click();
                    Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Assert.That(Properties.driver.PageSource.Contains("ATest"), Is.EqualTo(false),
                                                  "The test cannot be deleted");
                    Console.WriteLine("ATest Successfully Deleted");
                }
                else
                {
                    obj.seleTest.Click();
                    obj.btnDelete.Click();
                    obj.dialogDeletebtn.Click();
                    Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Assert.That(Properties.driver.PageSource.Contains("BTest"), Is.EqualTo(false),
                                                  "The test cannot be deleted");
                    Console.WriteLine("BTest Sucessfully Deleted");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Test doesn't Exist");

            }

            }
        public static void editMethod()
        {
            try
            {
                obj.lnkText.Click();
                obj.btnCancel.Click();
                obj.lnkText.Click();
                obj.btnEdit.Click();
                obj.btnCancel.Click();
                obj.lnkText.Click();
                obj.btnEdit.Click();
                Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                obj.editText.Clear();
                obj.editText.SendKeys("CTest");
                obj.editBtn.Click();
            }
            catch(Exception e)
            {
                //Console.WriteLine("Element not Found");           
            }

        }
        


            public static void Logout()
            {
                obj.icon.Click();
                obj.lnkLogout.Click();
            }
    }
}

