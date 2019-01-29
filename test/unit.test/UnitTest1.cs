using System;
using drone;
using drone.Controllers;
using Xunit;

namespace unit.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ServiceOne serviceOne = new ServiceOne();
            Assert.Equal("friend", serviceOne.GetResponse());
        }
    }
}
