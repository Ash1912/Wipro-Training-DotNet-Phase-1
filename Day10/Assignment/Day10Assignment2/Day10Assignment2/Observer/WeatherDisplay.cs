using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment2.Observer
{
    public class WeatherDisplay : IObserver
    {
        private string _name;
        public WeatherDisplay(string name) => _name = name;

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} Display: Temperature updated to {temperature}°C");
        }
    }
}
