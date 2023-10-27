using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public class FurnitureCreateExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            IFurniceFactory tableFactory;
            IFurniceFactory chairFactory;
            IFurniture table;
            IFurniture chair;

            tableFactory = new TableFactory();
            table = tableFactory.CreateFurniture();

            chairFactory = new ChairFactory();
            chair = chairFactory.CreateFurniture();

            table.Assemble();
            chair.Assemble();
        }

    }
}
