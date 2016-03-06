using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class PoolObject:IPoolObject
    {
        public int Number { get; set; }
        public DateTime? Time { get; set; }       
    }
}
