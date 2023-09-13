using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class PoorCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _vehicleType = VehicleType.Poor_Car;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _baseCost = 50;
        }

        public override void SetVehicleType()
        {
            _chargesPerUnitDistance = 10;
        }
    }
}
