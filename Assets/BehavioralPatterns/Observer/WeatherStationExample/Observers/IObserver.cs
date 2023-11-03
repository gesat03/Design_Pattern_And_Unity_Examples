using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    // Observer Interface

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
