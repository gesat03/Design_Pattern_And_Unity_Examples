using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class Circle : MonoBehaviour, IShape
    {
        public int _numSegment;
        public float _radius;
        bool _enableGizmos;

        public Circle(float radius, int numSegment)
        {
            _radius = radius;
            _numSegment = numSegment;
            _enableGizmos = false;
        }

        public void Draw(EShapeColor color)
        {
            _enableGizmos = true;
            Debug.Log("Circle shape with " + color.ToString() + " color" + " with " + _radius + " m radius.");
        }

        void DrawCircle()
        {
            float angleIncrement = 360f / _numSegment;
            Vector3 previousPoint = Vector3.zero;

            for (int i = 0; i <= _numSegment; i++)
            {
                float angle = i * angleIncrement;
                float x = Mathf.Sin(Mathf.Deg2Rad * angle) * _radius;
                float z = Mathf.Cos(Mathf.Deg2Rad * angle) * _radius;
                Vector3 currentPoint = new Vector3(x, 0, z);

                if (i > 0)
                {
                    Gizmos.DrawLine(previousPoint, currentPoint);
                }

                previousPoint = currentPoint;
            }
        }

        private void OnDrawGizmos()
        {
            if (_enableGizmos)
            {
                DrawCircle();
            }
        }
    }
}
