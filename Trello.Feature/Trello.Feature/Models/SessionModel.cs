using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Trello.Feature.Models
{
    public class SessionModel
    {
        public ITestOutputHelper Output { get; private set; }
        private List<SessionObjectModel> SessionObjects { get; set; }
        
        public SessionModel()
        {
            SessionObjects = new List<SessionObjectModel>();
        }

        public SessionModel(ITestOutputHelper output) : this()
        {
            Output = output;
        }

        public T GetValueByType<T>()
        {
            return (T)SessionObjects.FirstOrDefault(o => o.Key == GetKeyFromType(typeof(T)))?.Value;
        }

        public void SaveValueByType<T>(T value)
        {
            RemoveValueByType<T>();
            SessionObjects.Add(new SessionObjectModel(GetKeyFromType(value.GetType()), value));
        }

        public object GetValueByKey(string key)
        {
            return SessionObjects.First(o => o.Key == key).Value;
        }

        public void SaveValueByKey(string key, string value)
        {
            RemoveValueByKey(key);
            SessionObjects.Add(new SessionObjectModel(key, value));
        }

        private void RemoveValueByType<T>()
        {
            if (GetValueByType<T>() != null)
                SessionObjects.RemoveAll(o => o.Key == GetKeyFromType(typeof(T)));
        }

        private void RemoveValueByKey(string key)
        {
            if (GetValueByKey(key) != null)
                SessionObjects.RemoveAll(o => o.Key == key);
        }

        private string GetKeyFromType(Type type)
        {
            return $"{type.Namespace}{type.Name}";
        }
    }
}
