using Common.Selenium.Logic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Models;
using WebAutomation.Models.Trello.AddBoard;

namespace WebAutomation.Logic.Trello.AddBoard
{
    public class AddBoardModal : IWebAutomationModal
    {
        public AddBoardModal(WebModel web) : base(web)
        {
        }
        
        public void SetFields(AddBoardModel addBoardModel)
        {
            Web.Driver.FindElement(AddBoardScreenReference.AddBoardTitleTextbox).SendKeys(addBoardModel.Title);
            Web.Driver.FindElement(AddBoardScreenReference.SecurityDropdown).Click();
            IWebElement securityOptionDropdown = Web.Driver.FindClickableElement(AddBoardScreenReference.SecurityOption(addBoardModel.Security), Web.UniversalTimeout);
            securityOptionDropdown.Click();
            Web.Driver.WaitForStaleElement(securityOptionDropdown, Web.UniversalTimeout);
            if (!String.IsNullOrWhiteSpace(addBoardModel.Color))
                Web.Driver.FindElement(AddBoardScreenReference.BoardColorButton(addBoardModel.Color)).Click();
        }

        public void CreateBoard()
        {
            Web.Driver.FindElement(By.XPath("//span[text()='Create Board']/parent::button")).Click();
        }
    }
}
