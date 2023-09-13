using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class ExpensiveCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _baseCost = 150;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 30;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Expensive_Car;
        }
    }
}
