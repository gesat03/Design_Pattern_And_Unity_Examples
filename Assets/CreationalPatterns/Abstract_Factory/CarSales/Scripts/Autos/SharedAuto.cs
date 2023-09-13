using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class SharedAuto : BaseAuto
    {
        public override void SetBaseCost()
        {
            _vehicleType = VehicleType.Shared_Auto;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _baseCost = 0;
        }

        public override void SetVehicleType()
        {
            _chargesPerUnitDistance = 10;
        }
    }
}
