using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class FurnitureCreateExample : MonoBehaviour
    {

        private void Start()
        {
            IFurniture metalTable;
            IFurniture metalChair;
            IFurniture metalCabinet;

            IFurniture woodenTable;
            IFurniture woodenChair;
            IFurniture woodenCabinet;

            IFurnitureFactory metalFactory = new MetalFurnitureFactory();
            IFurnitureFactory woodedFactory = new WoodenFurnitureFactory();

            metalTable = metalFactory.CreateTable();
            metalChair = metalFactory.CreateChair();
            metalCabinet = metalFactory.CreateCabinet();

            woodenTable = woodedFactory.CreateTable();
            woodenChair = woodedFactory.CreateChair();
            woodenCabinet = woodedFactory.CreateCabinet();

            metalTable.Assemble();
            metalChair.Assemble();
            metalCabinet.Assemble();

            woodenTable.Assemble();
            woodenChair.Assemble();
            woodenCabinet.Assemble();
        }

    }
}
