using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VehicleExample
{
    public class RentACar : MonoBehaviour
    {
        public Text ScreenText;

        public VehicleType VehicleType;
        public VehicleFactoryType VehicleFactoryType;
        public int distance;

        BaseVehicleFactory carFactory;

        private void Start()
        {
            carFactory = FactoryProvider.GetVehicleFactory(VehicleFactoryType.Car);
            IVehicle poorCar = carFactory.GetVehicle(VehicleType.Poor_Car);
            poorCar.Booking(20);
        }

        public void SelectCar()
        {
            carFactory = FactoryProvider.GetVehicleFactory(VehicleFactoryType);
            IVehicle poorCar = carFactory.GetVehicle(VehicleType);
            poorCar.Booking(20);
            ScreenText.text = poorCar.FinalMessage(20);
        }

    }
}
