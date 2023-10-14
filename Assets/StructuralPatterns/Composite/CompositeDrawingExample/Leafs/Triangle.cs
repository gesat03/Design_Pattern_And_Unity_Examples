using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class Triangle : IShape
    {
        float _triSize;

        public Triangle(float triSize)
        {
            _triSize = triSize;
        }

        public void Draw(EShapeColor color)
        {
            Debug.Log("Triangle shape with " + color.ToString() + " color" + " with " + _triSize + " m size.");
        }

        void DrawTriangle()
        {
            float halfSize = _triSize / 2;

            // Üçgenin köşe noktalarını hesaplayın
            Vector3 pointA = new Vector3(0f, -halfSize, 0f);
            Vector3 pointB = new Vector3(-halfSize, halfSize, 0f);
            Vector3 pointC = new Vector3(halfSize, halfSize, 0f);

            Gizmos.DrawLine(pointA, pointB);
            Gizmos.DrawLine(pointB, pointC);
            Gizmos.DrawLine(pointC, pointA);
        }

    }
}
