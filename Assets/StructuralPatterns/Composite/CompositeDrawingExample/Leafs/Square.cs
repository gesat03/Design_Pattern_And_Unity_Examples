using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class Square : IShape
    {
        public void Draw(EShapeColor color)
        {
            Debug.Log("Square shape with " + color.ToString() + " color");
        }
    }
}
