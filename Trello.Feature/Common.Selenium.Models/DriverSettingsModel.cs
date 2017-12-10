using Common.Selenium.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Selenium.Models
{
    public class DriverSettingsModel
    {
        public WebDriverType WebDriverType { get; private set; }
        public bool IsMaximized { get; private set; }
        public bool IsDisplayedOnSecondMonitor { get; private set; }

        public DriverSettingsModel(string webDriverType, bool isMaximized = true, bool isDisplayedOnSecondMonitor = false)
            : this((WebDriverType)Enum.Parse(typeof(WebDriverType), webDriverType), isMaximized, isDisplayedOnSecondMonitor)
        {
        }

        public DriverSettingsModel(WebDriverType webDriverType, bool isMaximized = true, bool isDisplayedOnSecondMonitor = false)
        {
            WebDriverType = webDriverType;
            IsMaximized = isMaximized;
            IsDisplayedOnSecondMonitor = isDisplayedOnSecondMonitor;
        }
    }
}
