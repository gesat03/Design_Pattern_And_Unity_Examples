using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class PersonalAuto : BaseAuto
    {
        public override void SetBaseCost()
        {
            _vehicleType = VehicleType.Personal_Auto;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _baseCost = 10;
        }

        public override void SetVehicleType()
        {
            _chargesPerUnitDistance = 15;
        }
    }
}
