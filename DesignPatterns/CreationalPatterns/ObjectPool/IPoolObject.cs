using System;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public interface IPoolObject
    {
        int Number { get; set; }
        DateTime? Time { get; set; }
    }
}