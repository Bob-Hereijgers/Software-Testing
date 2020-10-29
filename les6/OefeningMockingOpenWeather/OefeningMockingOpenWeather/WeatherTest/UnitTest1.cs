using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OefeningMockingOpenWeather;

namespace WeatherTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetCurrentWeatherInAntwerp_Returns_Brrr_If_Temp_Is_Below_Zero()
        {
            //Arrange
            var openWeatherMapApi = new Mock<IOpenWeatherMapApi>();
            openWeatherMapApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(-1);

            //Act
            var weatherService = new WeatherService(openWeatherMapApi.Object);

            //Assert
            Assert.AreEqual("Brrrr, it's freezing", weatherService.GetCurrentWeatherInAntwerp());
        }
    }
}
