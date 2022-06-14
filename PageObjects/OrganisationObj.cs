using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    class OrganisationObj
    {
        public OrganisationObj()
        {
            PageFactory.InitElements(Properties.driver, this);
        }
        [FindsBy(How = How.Id, Using = "menu_admin_Organization")]
        public IWebElement lnkOrg { get; set; }

        [FindsBy(How = How.LinkText, Using = "General Information")]
        public IWebElement lnkGenInfo { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveGenInfo")]
        public IWebElement BtnSaveGenInfo { get; set; }

        [FindsBy(How = How.Name, Using = "organization[name]")]
        public IWebElement txtOrgName { get; set; }

       [FindsBy(How = How.LinkText, Using = "Locations")]
        public IWebElement lnkLoc { get; set; }

        [FindsBy(How = How.Name, Using = "location[name]")]
        public IWebElement txtLocName { get; set; }

        [FindsBy(How = How.Name, Using = "location[country]")]
        public IWebElement ddlLocCountry { get; set; }

        [FindsBy(How = How.Name, Using = "searchLocation[name]")]
        public IWebElement txtSearchName { get; set; }

        [FindsBy(How = How.Name, Using = "searchLocation[country]")]
        public IWebElement txtSearchCntry { get; set; }

        [FindsBy(How = How.Id, Using = "btnSearch")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='left']/a[text()='Padi']")]
        public IWebElement lnkLocPadi { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Chennai']/../preceding::input[@type='checkbox'][1]")]
        public IWebElement chkLocPadi { get; set; }

    }
}
