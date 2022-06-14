using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    class PayGradeObj
    {

        public PayGradeObj()
        {
            PageFactory.InitElements(Properties.driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Pay Grades")]
        public IWebElement lnkPayGrades { get; set; }

        [FindsBy(How = How.Name, Using = "payGrade[name]")]
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddCurrency")]
        public IWebElement btnAddCurrency { get; set; }

        [FindsBy(How = How.Id, Using = "payGradeCurrency_currencyName")]
        public IWebElement txtCurrency { get; set; }

        [FindsBy(How = How.Id, Using = "payGradeCurrency_minSalary")]
        public IWebElement txtMinSalary { get; set; }

        [FindsBy(How = How.Id, Using = "payGradeCurrency_maxSalary")]
        public IWebElement txtMaxSalary { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveCurrency")]
        public IWebElement btnSaveCurrency { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='BTest']/../preceding::input[@type='checkbox'][1]")]
        public IWebElement chkBTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='left']/a[text()='ATest']")]
        public IWebElement lnkText { get; set; }


    }
}
