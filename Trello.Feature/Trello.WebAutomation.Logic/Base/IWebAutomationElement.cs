using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Models;

namespace WebAutomation.Logic.Base
{
    public abstract class IWebAutomationElement : IWebAutomationBase
    {
        protected IWebAutomationElement(WebModel web) : base(web)
        {
        }
    }
}
