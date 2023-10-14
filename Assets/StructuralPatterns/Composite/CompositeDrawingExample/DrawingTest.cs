using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class DrawingTest : MonoBehaviour
    {
        Drawing _drawing;

        void Start()
        {
            _drawing = gameObject.AddComponent<Drawing>();

            Triangle triangle = new Triangle(2f);
            Circle circle = gameObject.AddComponent<Circle>();
            //circle._radius = 2;
            //circle._numSegment = 100;
            Circle circle2 = gameObject.AddComponent<Circle>();
            Square square = new Square();

            _drawing.Add(triangle);
            _drawing.Add(square);
            _drawing.Add(circle);
            _drawing.Add(circle2);

            _drawing.Draw(EShapeColor.Red);

            _drawing.Remove(circle);

            _drawing.Draw(EShapeColor.Blue);

           // _drawing.Clear();
        }

    }
}
