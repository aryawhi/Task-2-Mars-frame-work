using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    internal class ShareSkillBase
    {

        //Enter the Description in textbox
        [FindsBy(How = How.Xpath, Using = "//*[@id='service - listing - section")]//*div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")
        private IWebElement Description { get; set; }
    }
}