using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class RegularCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _baseCost = 100;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 20;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Regular_Car;
        }

    }
}
