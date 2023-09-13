using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class AutoFactory : BaseVehicleFactory
    {
        public override IVehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Personal_Auto:
                    return new PersonalAuto();
                case VehicleType.Shared_Auto:
                    return new SharedAuto();
                default:
                    return new PersonalAuto();
            }
        }
    }
}
