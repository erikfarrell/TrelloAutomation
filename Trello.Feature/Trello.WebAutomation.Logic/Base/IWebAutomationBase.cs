using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Models;

namespace WebAutomation.Logic.Base
{
    public abstract class IWebAutomationBase
    {
        protected WebModel Web { get; set; }

        protected IWebAutomationBase(WebModel web)
        {
            Web = web;
        }
    }
}
