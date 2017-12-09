using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Feature.Models
{
    public class SessionObjectModel
    {
        public string Key { get; private set; }
        public object Value { get; private set; }

        public SessionObjectModel(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
