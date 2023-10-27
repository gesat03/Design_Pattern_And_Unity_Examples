using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public class Chair : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Chair assembled...");
        }
    }
}
