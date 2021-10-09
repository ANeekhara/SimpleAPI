using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {
         WeatherForecastController controller = new WeatherForecastController();
         [Fact]
         public void GetReturnMyName()
         {
            var returnValue = controller.Get(1);
            Assert.Equal("Ak", returnValue);
         }

        [Fact]
        public void Test1()
        {

        }

    }
}
