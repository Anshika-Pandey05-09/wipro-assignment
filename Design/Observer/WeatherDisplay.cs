using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Observer
{
    public class WeatherDisplay : IObserver
    {
        private string _displayName;

        public WeatherDisplay(string displayName)
        {
            _displayName = displayName;
        }

        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"{_displayName} => Temperature: {temperature}°C, Humidity: {humidity}%");
        }
    }
}
