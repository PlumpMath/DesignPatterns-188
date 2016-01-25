using DesignPatterns.CreationalPatterns.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DesignPatterns.CreationalPatterns
{
    public class PoolTests
    {
        [Fact]
        public void WhenGet_ShouldReturnPoolObject()
        {
            //act
            PoolObject item = Pool.Instance.Get();
            //assert
            Assert.NotNull(item);
            Assert.NotNull(item.Time);
        }

        [Fact]
        public void WhenRelase_ShouldSetTimeToNull()
        {
            //arrange
            PoolObject item = Pool.Instance.Get();
            //act
            Pool.Instance.Relase(item);
            //assert            
            Assert.Null(item.Time);
        }

        [Fact]
        public void WhenGet_WithObjectInPool_ShouldReturnObjectFromPool()
        {
            //arrange
            PoolObject first = Pool.Instance.Get();           
            Pool.Instance.Relase(first);
            //act
            PoolObject sec = Pool.Instance.Get();
            //assert            
            Assert.Equal(first.Number, sec.Number);
        }
    }
}
