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
using WebAutomation.Logic.Trello.Board.TopBar;
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
            Web.Driver.FindClickableElement(AddBoardScreenReference.SecurityOption(addBoardModel.Security), Web.UniversalTimeout).Click();
            Web.Driver.WaitForInvisibleElement(AddBoardScreenReference.PopOver, Web.UniversalTimeout);
            if (!String.IsNullOrWhiteSpace(addBoardModel.Color))
                Web.Driver.FindVisibleElement(AddBoardScreenReference.BoardColorButton(addBoardModel.Color), Web.UniversalTimeout).Click();
        }

        public BoardPage CreateBoard()
        {
            Web.Driver.FindElement(AddBoardScreenReference.CreateBoardButton).Click();
            Web.Driver.WaitForClickableElement(TopBarScreenReference.MemberMenu, Web.UniversalTimeout);
            Web.Driver.WaitForInvisibleElement(AddBoardScreenReference.Window, Web.UniversalTimeout);

            return new BoardPage(Web);
        }
    }
}
