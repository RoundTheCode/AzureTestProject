using RoundTheCode.AzureTestProject.Shared;
using Xunit;

namespace RoundTheCode.AzureTestProject.XUnit
{
    public class MyTest
    {
        [Fact]
        public void CheckIsOK()
        {
            var myService = new MyService();

            Assert.True(myService.IsOK());
        }

        [Fact]
        public void CheckIsNotOK()
        {
            var myService = new MyService();

            Assert.False(!myService.IsOK());
        }
    }
}