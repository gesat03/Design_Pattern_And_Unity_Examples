using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public class TableFactory : IFurniceFactory
    {
        public IFurniture CreateFurniture()
        {
            return new Table();
        }
    }
}
