using DesignPatterns.CreationalPatterns.Entities;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public interface ICarFactory
    {
        ICar Create();
    }
}