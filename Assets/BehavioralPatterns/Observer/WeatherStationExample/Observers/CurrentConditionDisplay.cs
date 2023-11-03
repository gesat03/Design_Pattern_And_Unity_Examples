using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    // Observer 3 

    public class CurrentConditionDisplay : IObserver
    {
        private float _temp;
        private float _humidity;

        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Debug.Log($"Current Condition: Temperature={_temp}°C, Humidity={_humidity}%");
        }
    }
}
