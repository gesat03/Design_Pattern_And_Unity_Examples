using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class MetalCabinet : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Metal cabinet assembled...");
        }
    }
}
