using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class FactoryProvider : MonoBehaviour
    {
        
        public static BaseVehicleFactory GetVehicleFactory(VehicleFactoryType vehicleFactoryType)
        {
            switch (vehicleFactoryType)
            {
                case VehicleFactoryType.Car:
                    return new CarFactory();
                case VehicleFactoryType.Auto:
                    return new AutoFactory();
                case VehicleFactoryType.Bike:
                    return new BikeFactory();
                default:
                    return new CarFactory();
            }
        }

    }
}
