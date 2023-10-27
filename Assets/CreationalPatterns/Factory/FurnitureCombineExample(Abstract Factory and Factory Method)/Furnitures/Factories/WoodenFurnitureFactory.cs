using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class WoodenFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new WoodenCabinet();
        }

        public IFurniture CreateChair()
        {
            return new WoodenChair();
        }

        public IFurniture CreateTable()
        {
            return new WoodenTable();
        }
    }
}
