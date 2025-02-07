using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment2.Observer;

namespace Day10Assignment2.Tests
{
    public class ObserverTests
    {
        [Fact]
        public void Observer_ReceivesTemperatureUpdates()
        {
            var weatherStation = new WeatherStation();
            var display = new WeatherDisplay("Test");

            weatherStation.RegisterObserver(display);
            weatherStation.SetTemperature(25.0f);

            // No direct assertion, but check console logs
        }
    }
}
