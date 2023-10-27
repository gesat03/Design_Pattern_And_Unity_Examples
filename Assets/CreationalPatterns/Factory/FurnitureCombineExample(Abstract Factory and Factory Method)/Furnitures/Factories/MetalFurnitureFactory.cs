using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class MetalFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new MetalCabinet();
        }

        public IFurniture CreateChair()
        {
            return new MetalChair();
        }

        public IFurniture CreateTable()
        {
            return new MetalTable();
        }
    }
}
