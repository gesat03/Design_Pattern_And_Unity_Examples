using UnityEngine;

namespace CompositeDrawingExample
{
    public class Square : IShape
    {
        EShapeColor _color;
        float _length;

        public Square(EShapeColor color, float lenght)
        {
            _color = color;
            _length = lenght;
        }

        public void Draw()
        {
            int numSegment = 4;
            float angleIncrement = 360f / numSegment;
            Vector3 previousPoint = Vector3.zero;

            for (int i = 0; i <= numSegment; i++)
            {
                float angle = i * angleIncrement;
                float x = Mathf.Sin(Mathf.Deg2Rad * angle) * _length;
                float z = Mathf.Cos(Mathf.Deg2Rad * angle) * _length;
                Vector3 currentPoint = new Vector3(x, 0, z);

                if (i > 0)
                {
                    Gizmos.color = SetDrawColor.Set(_color);
                    Gizmos.DrawLine(previousPoint, currentPoint);
                }

                previousPoint = currentPoint;
            }
        }
    }
}
