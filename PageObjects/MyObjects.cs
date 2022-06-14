using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    class MyObjects
    {
        public MyObjects()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "txtUsername")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "txtPassword")]
        public IWebElement txtPswd { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "menu_admin_viewAdminModule")]
        public IWebElement btnAdmin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Job")]
        public IWebElement btnJob { get; set; }

        [FindsBy(How = How.LinkText, Using = "Job Titles")]
        public IWebElement btnJobTitle { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement btnAdd { get; set; }

        [FindsBy(How = How.Name, Using = "jobTitle[jobTitle]")]
        public IWebElement txtJobTitle { get; set; }

        [FindsBy(How = How.Name, Using = "jobTitle[jobDescription]")]
        public IWebElement txtJobDesc { get; set; }

        [FindsBy(How = How.Id, Using = "jobTitle_jobSpec")]
        public IWebElement btnChooseFile { get; set; }


        [FindsBy(How = How.Name, Using = "jobTitle[note]")]
        public IWebElement txtNote { get; set; }

        [FindsBy(How = How.Name, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "btnCancel")]
        public IWebElement btnCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='ATest']/../preceding::input[@type='checkbox'][1]")]
        public IWebElement selTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='BTest']/../preceding::input[@type='checkbox'][1]")]
        public IWebElement seleTest { get; set; }


        [FindsBy(How = How.Id, Using ="btnDelete")]
        public IWebElement btnDelete { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='dialogDeleteBtn']")]
        public IWebElement dialogDeletebtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='left']/a[text()='Automation Tester']")]
        public IWebElement lnkText { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Automation Tester']")]
        public IWebElement editText { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        public IWebElement editBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='editButton']")]
        public IWebElement btnEdit { get; set; }

       

        [FindsBy(How = How.Id, Using = "welcome")]
        public IWebElement icon { get; set; }

        [FindsBy(How = How.LinkText, Using = "Logout")]
        public IWebElement lnkLogout { get; set; }


    }
}
