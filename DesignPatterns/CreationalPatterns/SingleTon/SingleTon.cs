using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.SingleTon
{
    public sealed class SingleTon
    {
        public static SingleTon Instance { get; private set; }
        static SingleTon()
        {
            Instance = new SingleTon();
        }
        private SingleTon()
        {

        }
    }
}
