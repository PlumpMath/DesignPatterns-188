using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class PoolObject
    {
        public int Number { get; private set; }
        public DateTime? Time { get; set; }
        public PoolObject(int number)
        {
            Number = number;           
        }
    }
}
