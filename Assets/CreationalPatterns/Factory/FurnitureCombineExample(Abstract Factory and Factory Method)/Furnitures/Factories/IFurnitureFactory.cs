using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public interface IFurnitureFactory
    {
        public IFurniture CreateChair();
        public IFurniture CreateTable();
        public IFurniture CreateCabinet();
    }
}
