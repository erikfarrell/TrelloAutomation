using Common.Selenium.Logic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Base;
using WebAutomation.Logic.Trello.Board;
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
            //TODO: Fix this - has a chance to fail and not select color right now
            Web.Driver.WaitForStaleElement(securityOptionDropdown, Web.UniversalTimeout);
            if (!String.IsNullOrWhiteSpace(addBoardModel.Color))
                Web.Driver.FindClickableElement(AddBoardScreenReference.BoardColorButton(addBoardModel.Color), Web.UniversalTimeout).Click();
        }

        public BoardPage CreateBoard()
        {
            Web.Driver.FindElement(AddBoardScreenReference.CreateBoardButton).Click();
            Web.Driver.WaitForInvisibleElement(AddBoardScreenReference.WindowOverlay, Web.UniversalTimeout);

            return new BoardPage(Web);
        }
    }
}
