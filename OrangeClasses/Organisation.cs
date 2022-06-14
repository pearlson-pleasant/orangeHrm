using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.OrangeClasses
{
   public static class Organisation
    {
        static MyObjects obj = new MyObjects();
        static PayGradeObj obj1 = new PayGradeObj();
        static OrganisationObj obj2 = new OrganisationObj();
        
        public static void genInfo()
        {
            MyMethods.AdminMethod();
            Actions act = new Actions(Properties.driver);
            act.MoveToElement(obj2.lnkOrg).Perform();
            act.MoveToElement(obj2.lnkGenInfo).Click().Perform();
            obj2.BtnSaveGenInfo.Click();
            obj2.txtOrgName.Clear();
            obj2.txtOrgName.SendKeys("ATest");
            obj2.BtnSaveGenInfo.Click();
            Assert.That(Properties.driver.PageSource.Contains("ATest"), Is.EqualTo(true), "ATest Doesn't Exist");
        }
        public static void location()
        {
            try
            {
                MyMethods.AdminMethod();
                Actions act = new Actions(Properties.driver);
                act.MoveToElement(obj2.lnkOrg).Perform();
                act.MoveToElement(obj2.lnkLoc).Click().Perform();
                obj.btnAdd.Click();
                obj2.txtLocName.SendKeys("Padi");
                new SelectElement(Properties.driver.FindElement(By.Name("location[country]"))).SelectByText("India");
                obj.btnSave.Click();
                obj2.txtSearchName.SendKeys("Padi");
                obj2.txtSearchCntry.SendKeys("India");
                obj2.btnSearch.Click();
                Assert.That(Properties.driver.PageSource.Contains("Padi"), Is.EqualTo(true), " The search location doesn't exist");
            }
            catch (Exception e)
            {
                //Console.WriteLine("Already Exist");
                IWebElement element = Properties.driver.FindElement(By.XPath("//span[text()='Already exists']"));
                if (element.Displayed == true)
                {
                    Console.WriteLine("Already Exist");
                    obj.btnCancel.Click();
                }
            }

        }
        public static void editLoc()
        {
            try
            {
                obj2.lnkLocPadi.Click();
                obj.btnSave.Click();
                obj2.txtLocName.Clear();
                obj2.txtLocName.SendKeys("Chennai");
                obj.btnSave.Click();
            }
            catch(Exception e)
            {
                Console.WriteLine("Element not found");
            }

        }
        public static void locDelete()
        {
            try
            {
                obj2.chkLocPadi.Click();
                obj.btnDelete.Click();
                obj.dialogDeletebtn.Click();
                Assert.That(Properties.driver.PageSource.Contains("Chennai"), Is.EqualTo(false), "Location cannot be deleted");
                Console.WriteLine("Location Successfully deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine("Element Not found");
            }

        }
    }
}
