using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    //Subject

    public class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private float _temp;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
        private void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
