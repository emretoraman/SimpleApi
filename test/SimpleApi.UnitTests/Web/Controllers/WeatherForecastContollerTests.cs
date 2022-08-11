using SimpleApi.Web.Controllers;

namespace SimpleApi.UnitTests.Web.Controllers
{
    public class WeatherForecastContollerTests
    {
        private readonly WeatherForecastController _controller;

        public WeatherForecastContollerTests()
        {
            _controller = new WeatherForecastController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsNotNull()
        {
            var returnValue = _controller.Get();
            Assert.NotNull(returnValue);
        }
    }
}