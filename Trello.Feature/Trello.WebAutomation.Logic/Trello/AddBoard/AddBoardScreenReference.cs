using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation.Logic.Trello.AddBoard
{
    public static class AddBoardScreenReference
    {
        public static By AddBoardTitleTextbox => By.XPath("//input[@placeholder='Add board title']");
        public static By SecurityDropdown => By.XPath("//button[contains(@class, 'subtle-chooser-trigger')]");
        public static By SecurityOption(string option) => By.XPath($"//ul[contains(@class, 'vis-chooser')]//span[text()='{option}']/parent::a");
        public static By BoardColorButton(string color) => By.XPath($"//button[@title='{color.ToLower()}']");
        public static By CreateBoardButton => By.XPath("//span[text()='Create Board']/parent::button");
        public static By WindowOverlay => By.XPath("//div[contains(@class, 'window-overlay')]");
    }
}
