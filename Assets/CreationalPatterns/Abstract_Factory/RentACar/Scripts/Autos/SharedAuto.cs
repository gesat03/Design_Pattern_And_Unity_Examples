using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class SharedAuto : BaseAuto
    {
        public override void SetBaseCost()
        {
            _baseCost = 0;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 10;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Shared_Auto;
        }
    }
}
