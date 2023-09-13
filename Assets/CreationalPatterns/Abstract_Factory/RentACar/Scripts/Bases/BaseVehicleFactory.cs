using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public abstract class BaseVehicleFactory
    {
        public abstract IVehicle GetVehicle(VehicleType vehicleType);
    }
}
