using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class NormalBike : BaseBike
    {
        public override void SetBaseCost()
        {
            _baseCost = 20;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 5;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Shared_Auto;
        }
    }
}
