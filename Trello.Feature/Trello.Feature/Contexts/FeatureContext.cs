using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Feature.Models;

namespace Trello.Feature.Contexts
{
    public class FeatureContext
    {
        public SessionModel SessionModel { get; private set; }

        public FeatureContext()
        {
            SessionModel = new SessionModel();
        }
    }
}
