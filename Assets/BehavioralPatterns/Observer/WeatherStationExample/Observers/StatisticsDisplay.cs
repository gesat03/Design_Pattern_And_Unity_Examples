using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    // Observer 2

    public class StatisticsDisplay : IObserver
    {
        private List<float> _tempList = new List<float>();
        private float _tempSum;
        private int _numReadings;

        public void Update(float temp, float humidity, float pressure)
        {
            _tempList.Add(temp);
            _numReadings++;

            Display();
        }

        public void Display()
        {
            Debug.Log($"Average Temperature: {TemperatureSummation() / _numReadings}°C");
        }

        private float TemperatureSummation()
        {
            _tempSum = 0;

            foreach (var item in _tempList)
            {
                _tempSum += item;
            }

            return _tempSum;
        }
    }
}
