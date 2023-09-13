using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class CarFactory : BaseVehicleFactory
    {
        public override IVehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Poor_Car:
                    return new PoorCar();
                case VehicleType.Regular_Car:
                    return new RegularCar();
                case VehicleType.Expensive_Car:
                    return new ExpensiveCar();
                default:
                    return new RegularCar();
            }
        }
    }
}
