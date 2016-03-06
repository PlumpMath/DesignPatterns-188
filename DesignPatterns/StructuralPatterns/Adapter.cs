using System;

namespace DesignPatterns.StructuralPatterns
{

    public interface IAdaptee
    {
        void Execute();
    }

    public class Adapter
    {
        private readonly IAdaptee _adaptee;

        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Adapt()
        {
            _adaptee.Execute();
        }
    }
}