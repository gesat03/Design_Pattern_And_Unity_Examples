using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public abstract class BaseBike : IVehicle
    {
        protected VehicleType _vehicleType;
        protected int _baseCost;
        protected int _chargesPerUnitDistance;

        public void Booking(int distance)
        {
            SetVehicleType();
            SetBaseCost();
            SetVehicleChargesPerUnitsDistace();
            int cost = CalculateCostOfBooking(distance);

            Debug.Log("You have booked a " + _vehicleType.ToString() + " Bike for a distance of " + distance + " kms at a total cost of " + cost + ". ");
        }

        public int CalculateCostOfBooking(int distance)
        {
            int serviceCharge = 2;

            return _baseCost + _chargesPerUnitDistance * distance + serviceCharge;
        }

        public string FinalMessage(int distance)
        {
            int cost = CalculateCostOfBooking(distance);

            return "You have booked a " + _vehicleType.ToString() + " Bike for a distance of " + distance + " kms at a total cost of " + cost + ". ";
        }

        public abstract void SetBaseCost();

        public abstract void SetVehicleChargesPerUnitsDistace();

        public abstract void SetVehicleType();
    }
}
