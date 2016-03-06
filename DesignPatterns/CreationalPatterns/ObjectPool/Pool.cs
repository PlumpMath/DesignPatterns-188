using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public sealed class Pool<T> where T :class,IPoolObject,new()
    {
        public static Pool<T> Instance { get; private set; }
        static Pool()
        {
            Instance = new Pool<T>();
        }

        private readonly List<T> _inUseObjects;
        private readonly List<T> _availableObjects;
        private readonly object _lock;

        private int _counter;

        private Pool()
        {
            _inUseObjects = new List<T>();
            _availableObjects = new List<T>();
            _counter = -1;
            _lock = new object();
        }

        public T Get()
        {
            lock (_lock)
            {
                T item;

                if (_availableObjects.Count == 0)
                {
                    _counter++;
                    item = new T();
                    item.Number = _counter;
                }
                else
                {
                    item = _availableObjects[0];
                    _availableObjects.Remove(item);
                }

                _inUseObjects.Add(item);
                item.Time = DateTime.Now;
                return item;
            }
        }

        public void Relase(T item)
        {
            Clean(item);

            lock (_lock)
            {
                _availableObjects.Add(item);
                _inUseObjects.Remove(item);
            }            
        }

        private void Clean(T item)
        {
            item.Time = null;
        }
    }
}
