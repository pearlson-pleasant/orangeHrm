using System;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OrangeHRM.OrangeClasses;
using OrangeHRM.PageObjects;
using SeleniumExtras.PageObjects;

namespace OrangeHRM
{
  //  [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void initial()
        {
             //MyMethods.initialize();
             Properties.driver = new ChromeDriver();
             //Properties.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");
           Properties.driver.Navigate().GoToUrl(TestContext.Parameters.Get("Initialization"));
             Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
             Console.WriteLine("OrangeHRM page opened");
        }
        [Test, Category("Login")]
        public void valLogin()
        {
            // MyMethods.initialize();
            MyMethods.LoginMethod();
            Assert.Pass();
            //MyMethods.AdminMethod();
            //MyMethods.AddMethod();
        }
        [Test, Category("ValMethods")]
        public void valTitleJob()
        {
            MyMethods.AdminMethod();
            MyMethods.AddMethod();
            MyMethods.deleteMethod();
            MyMethods.editMethod();
            PayGrades.addPayGrade();
            PayGrades.addCurrency();
            PayGrades.editPayGrades();
            PayGrades.delPayGrades();
            Organisation.genInfo();
            Organisation.location();
            Organisation.editLoc();
            Organisation.locDelete();
        }
        [OneTimeTearDown]
        public void Zzcleanup()
        {
            MyMethods.Logout();
            Properties.driver.Close();
        }
    }   }

