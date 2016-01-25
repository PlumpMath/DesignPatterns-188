using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public sealed class Pool
    {
        public static Pool Instance { get; private set; }
        static Pool()
        {
            Instance = new Pool();
        }

        private readonly List<PoolObject> _inUseObjects;
        private readonly List<PoolObject> _availableObjects;
        private readonly object _lock;

        private int _counter;

        private Pool()
        {
            _inUseObjects = new List<PoolObject>();
            _availableObjects = new List<PoolObject>();
            _counter = -1;
            _lock = new object();
        }

        public PoolObject Get()
        {
            lock (_lock)
            {
                PoolObject item;

                if (_availableObjects.Count == 0)
                {
                    _counter++;
                    item = new PoolObject(_counter);
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

        public void Relase(PoolObject item)
        {
            Clean(item);

            lock (_lock)
            {
                _availableObjects.Add(item);
                _inUseObjects.Remove(item);
            }            
        }

        private void Clean(PoolObject item)
        {
            item.Time = null;
        }
    }
}
