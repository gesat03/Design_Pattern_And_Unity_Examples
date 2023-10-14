using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class Drawing : MonoBehaviour, IShape
    {
        private List<IShape> _shapes = new List<IShape>();

        public void Draw(EShapeColor color)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(color);
            }
        }

        public void Add(IShape shape)
        {
            _shapes.Add(shape);
        }

        public void Remove(IShape shape)
        {
            _shapes.Remove(shape);
        }

        public void Clear()
        {
            _shapes.Clear();
            Debug.Log("All shapes cleared");
        }
    }
}
