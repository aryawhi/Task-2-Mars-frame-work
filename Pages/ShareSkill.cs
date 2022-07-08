using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V101.Cast;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    internal class EnterShareSkill
    { 
        public EnterShareSkills
        

        //Click on ShareSkill Button
        [FindsBy(How = How.Name, Sink = "//*[@id='service - listing - section")]//*[@id="service-listing-section"]/section[1]/div/div[2]/a)
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*[div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[3]/div[2]/div/div[1]/select")
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")


        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[4]/div[2]/div")
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.Xpath, Using = "//*[@id='requiredField")]//*form/div[5]/div[@class='twelve wide column']/div/div[@class='field")
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the service type of hourly basis service
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")
        private IWebElement Listing { get; set; }

        //Select the Location Type
        [FindsBy(How = How.Xpath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on location type onsite
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[6]/div[2]/div/div[1]/div/label")


        //Click on Start Date dropdown
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[7]/div[2]/div/div[1]/div[1]/label")]
        private IWebElement StartDateDropDown { get; set; }

        //Available day select Monday
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing -section")]//*[@id="service-listing-section"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/label")]

        private IWebElement Available; Monday

        //Click on End Date dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section")]//*div[2]/div/form/div[7]/div[2]/div/div[1]/div[3]/label)]

       Private IWebElement EndDateDropDown { get; set; }


        //Storing the table of available days
        [FindsBy(How = How.Name, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.Xpath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.Xpath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.Xpath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.Xpath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.Xpath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.Xpath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.Xpath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.Xpath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
        public Day Monday1 { get => Monday; set => Monday = value; }

        private int FindsBy(How how, object p)
        {
            throw new NotImplementedException();
        }

        internal void EnterShareSkill()
        {

        }

        internal void EditShareSkill()
        {

        }
    }

    internal interface IWebElement
    {
        void Click();
        void SendKeys(string v);
    }
}
