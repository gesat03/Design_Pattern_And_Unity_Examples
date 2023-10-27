using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class WoodenCabinet : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Wooden cabinet assembled...");
        }
    }
}
