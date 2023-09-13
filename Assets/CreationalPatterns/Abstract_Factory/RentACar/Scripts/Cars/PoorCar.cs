using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class PoorCar : BaseCar
    {
        public override void SetBaseCost()
        {
            _baseCost = 50;
        }

        public override void SetVehicleChargesPerUnitsDistace()
        {
            _chargesPerUnitDistance = 10;
        }

        public override void SetVehicleType()
        {
            _vehicleType = VehicleType.Poor_Car;
        }
    }
}
