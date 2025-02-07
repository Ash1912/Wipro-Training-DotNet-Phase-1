using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment2.Observer
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private float _temperature;

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
                observer.Update(_temperature);
        }

        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"WeatherStation: New temperature is {temperature}°C");
            NotifyObservers();
        }
    }
}
