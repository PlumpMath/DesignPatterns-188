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
            PoolObject item = Pool<PoolObject>.Instance.Get();
            //assert
            Assert.NotNull(item);
            Assert.NotNull(item.Time);
        }

        [Fact]
        public void WhenRelase_ShouldSetTimeToNull()
        {
            //arrange
            PoolObject item = Pool<PoolObject>.Instance.Get();
            //act
            Pool<PoolObject>.Instance.Relase(item);
            //assert            
            Assert.Null(item.Time);
        }

        [Fact]
        public void WhenGet_WithObjectInPool_ShouldReturnObjectFromPool()
        {
            //arrange
            PoolObject first = Pool<PoolObject>.Instance.Get();           
            Pool<PoolObject>.Instance.Relase(first);
            //act
            PoolObject sec = Pool<PoolObject>.Instance.Get();
            //assert            
            Assert.Equal(first.Number, sec.Number);
        }
    }
}
