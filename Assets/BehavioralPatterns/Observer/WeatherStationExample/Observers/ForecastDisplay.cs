using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    // Observer 1 

    public class ForecastDisplay : IObserver
    {
        private float _lastPressure;
        private float _currentPressure;

        public void Update(float temp, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            if(_currentPressure > _lastPressure)
            {
                Debug.Log("Weather is improving, expect warmer and drier conditions.");
            }
            else if (_currentPressure < _lastPressure)
            {
                Debug.Log("Weather is deteriorating, expect cooler and rainy conditions.");
            }
            else
            {
                Debug.Log("Weather conditions are stable.");
            }
        }
    }
}
