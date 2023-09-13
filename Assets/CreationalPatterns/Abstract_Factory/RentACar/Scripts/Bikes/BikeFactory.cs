using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class BikeFactory : BaseVehicleFactory
    {
        public override IVehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Normal_Bike:
                    return new NormalBike();
                case VehicleType.Sport_Bike:
                    return new SportBike();
                default:
                    return new NormalBike();
            }
        }
    }
}
