using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public class ChairFactory : IFurniceFactory
    {
        public IFurniture CreateFurniture()
        {
            return new Chair();
        }
    }
}
