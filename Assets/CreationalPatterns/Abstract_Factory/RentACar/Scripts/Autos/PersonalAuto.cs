using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class PersonalAuto : BaseAuto
    {
        public override void SetBaseCost()
        {
            _baseCost = 10;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 15;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Personal_Auto;
        }
    }
}
