using System;
using Xunit;
using Demoapi.Controllers;

namespace Demotest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,5,7)]
        [InlineData(5,5,10)]

        public void plus(int n1 , int n2 , int expected){
            var number = new ValuesController();
            var total = number.add(n1 , n2);
            Assert.Equal(expected , total);
        }
    }
}
