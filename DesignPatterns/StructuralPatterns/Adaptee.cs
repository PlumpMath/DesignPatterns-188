using System;
using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns
{
    public class Adaptee:IAdaptee
    {
        private int _count;

        public Adaptee()
        {
            _count = 0;
        }

        public void Execute()
        {
            _count++;
        }

        public int GetInvokedCount()
        {
            return _count;
        }
    }
}