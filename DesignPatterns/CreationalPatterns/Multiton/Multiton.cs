using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Multiton
{
    public class Multiton
    {
        public string Key { get; private set; }

        private Multiton()
        {
        }

        private Multiton(string key):this()
        {
            Key = key;
        }

        private static Dictionary<string, Multiton> _instances;

        public static Multiton GetInstance(string key)
        {
            if (!_instances.ContainsKey(key))
            {
                _instances[key] = new Multiton(key);
            }
            return _instances[key];
        }

        static Multiton()
        {
            _instances = new Dictionary<string, Multiton>();
        }
    }
}
