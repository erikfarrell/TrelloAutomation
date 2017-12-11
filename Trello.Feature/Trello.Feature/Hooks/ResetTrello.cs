using Common.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Trello.Feature.Contexts;
using WebAutomation.Logic.Trello.Board;
using WebAutomation.Logic.Trello.Board.BoardMenu;
using WebAutomation.Logic.Trello.Main;

namespace Trello.Feature.Hooks
{
    [Binding]
    public class ResetTrello
    {
        //TODO: Uncomment and finish coding reset hook
        [BeforeTestRun]
        public static void Reset()
        {
            TrelloContext trelloContext = new TrelloContext();

            MainPage trello = new MainPage(trelloContext.Web);

            BoardPage board = trello.GoToLoginPage().LogIn(
                Properties.Settings.Default.TrelloUsername,
                Crypto.Decrypt(Properties.Settings.Default.TrelloEncryptedPassword,
                Constants.Keys.Passphrase));

            //TODO: Loop through boards, permanently delete
            while (board.TopBar.BoardsMenu.GetBoardsButtonsFromMenu().Count > 0)
            {
                board.TopBar.BoardsMenu.GetBoardsButtonsFromMenu().First().Click();
                board.BoardMenu.ClickMore();
                board.BoardMenu.ClickCloseBoard();
                board.ClickPermanentlyDeleteBoard();
            }

            trelloContext.Web.Driver?.Dispose();
        }
    }
}
