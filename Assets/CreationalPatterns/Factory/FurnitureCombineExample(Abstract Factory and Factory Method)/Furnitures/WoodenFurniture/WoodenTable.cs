using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class WoodenTable : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Wooden table assembled...");
        }
    }
}
