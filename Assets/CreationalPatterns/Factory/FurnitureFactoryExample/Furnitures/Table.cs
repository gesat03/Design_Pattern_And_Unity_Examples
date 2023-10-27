using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public class Table : IFurniture
    {
        public void Assemble()
        {
            Debug.Log("Table assembled...");
        }
    }
}
