using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureCombineExample
{
    public class MetalChair : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Metal chair assembled...");
        }
    }
}
