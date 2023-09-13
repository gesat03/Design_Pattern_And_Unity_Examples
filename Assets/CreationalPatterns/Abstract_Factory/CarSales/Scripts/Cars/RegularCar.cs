using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class RegularCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _vehicleType = VehicleType.Regular_Car;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _baseCost = 100;
        }

        public override void SetVehicleType()
        {
            _chargesPerUnitDistance = 20;
        }

    }
}
