using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeatherStationExample
{
    public class WeatherStationController : MonoBehaviour
    {
        private void Start()
        {
            WeatherStation weatherStation = new WeatherStation();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

            weatherStation.RegisterObserver(currentConditionDisplay);
            weatherStation.RegisterObserver(statisticsDisplay);
            weatherStation.RegisterObserver(forecastDisplay);

            weatherStation.SetMeasurements(19, 23, 1023);
            weatherStation.SetMeasurements(15, 16, 1011);
            weatherStation.SetMeasurements(11, 9, 985);
        }
    }
}
