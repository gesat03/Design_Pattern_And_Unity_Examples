using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class ExpensiveCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _vehicleType = VehicleType.Expensive_Car;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _baseCost = 150;
        }

        public override void SetVehicleType()
        {
            _chargesPerUnitDistance = 30;
        }
    }
}
