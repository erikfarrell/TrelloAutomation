using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Logic.Trello.Board;
using WebAutomation.Models.Trello.AddBoard;
using Xunit;

namespace Asserts.Logic.Trello.AddBoard
{
    public class AddBoardAsserts
    {
        private BoardPage _boardPage;
        private AddBoardModel _model;

        public AddBoardAsserts(BoardPage boardPage, AddBoardModel model)
        {
            _boardPage = boardPage;
            _model = model;
        }

        public void AssertContent()
        {
            Assert.True(BoardExists());
        }

        private bool BoardExists()
        {
            foreach(string boardName in _boardPage.TopBar.BoardsMenu.GetBoardButtonNamesFromMenu())
                if (boardName == _model.Title)
                    return true;

            return false;
        }
    }
}
