using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GarbageCollector;

namespace VehicleExample
{
    public class RentACar : MonoBehaviour
    {
        public Text ScreenText;

        public Button SelectButton;

        public Dropdown VTDropdown;
        public Dropdown VTFDropDown;

        public VehicleType VehicleType;

        public VehicleFactoryType VehicleFactoryType;

        public int distance;

        BaseVehicleFactory selectedFactory;

        private void Init()
        {
            SelectButton.onClick.AddListener(SelectCar);

            VehicleFactoryType = VehicleFactoryType.Car;

            VehicleType = VehicleType.Poor_Car;
        }

        private void Start()
        {
            Init();
        }

        public void SelectFactory()
        {
            VehicleFactoryType = (VehicleFactoryType)VTFDropDown.value;

            DetermineVehicleTypes(VehicleFactoryType);
        }

        public void SelectVehicle()
        {
            VehicleType = (VehicleType)VTDropdown.value;
        }

        void DetermineVehicleTypes(VehicleFactoryType vehicleFactoryType)
        {
            List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();

            int enumStartNum;
            int enumEndNum;

            switch (vehicleFactoryType)
            {
                case VehicleFactoryType.Car:
                    enumStartNum = 0;
                    enumEndNum = 3;
                    break;
                case VehicleFactoryType.Auto:
                    enumStartNum = 3;
                    enumEndNum = 5;
                    break;
                case VehicleFactoryType.Bike:
                    enumStartNum = 5;
                    enumEndNum = 7;
                    break;
                default:
                    enumStartNum = 0;
                    enumEndNum = 3;
                    break;
            }

            for (int i = enumStartNum; i < enumEndNum; i++)
            {
                VehicleType vehicleElement = (VehicleType)i;

                options.Add(new Dropdown.OptionData(vehicleElement.ToString()));  
            }

            VTDropdown.ClearOptions();

            VTDropdown.AddOptions(options);
        }

        public void SelectCar()
        {
            selectedFactory = FactoryProvider.GetVehicleFactory(VehicleFactoryType);
            IVehicle selectedVehicle = selectedFactory.GetVehicle(VehicleType);
            selectedVehicle.Booking(20);
            ScreenText.text = selectedVehicle.FinalMessage(20);
        }

    }
}
