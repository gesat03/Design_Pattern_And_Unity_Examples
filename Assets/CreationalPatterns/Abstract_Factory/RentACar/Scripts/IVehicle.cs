using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public interface IVehicle
    {
        void Booking(int distance);
        string FinalMessage(int distance);
        void SetVehicleType();
        void SetBaseCost();
        void SetVehicleChargesPerUnitsDistace();
        int CalculateCostOfBooking(int distance);
    }
}
