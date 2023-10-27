using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class MetalTable : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Metal table assembled...");
        }
    }
}
