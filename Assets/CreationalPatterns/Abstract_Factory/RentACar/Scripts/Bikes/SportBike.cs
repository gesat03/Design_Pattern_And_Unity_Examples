using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class SportBike : BaseBike
    {
        public override void SetBaseCost()
        {
            _baseCost = 40;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 15;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Shared_Auto;
        }
    }
}
