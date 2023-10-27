using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class WoodenChair : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Wooden chair assembled...");
        }
    }
}
