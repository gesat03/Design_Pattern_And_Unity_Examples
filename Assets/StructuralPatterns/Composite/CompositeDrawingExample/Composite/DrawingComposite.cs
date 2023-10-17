using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class DrawingComposite : MonoBehaviour, IShape
    {
        private List<IShape> _shapes = new List<IShape>();

        bool _enableDrawing;

        public void Draw()
        {
            _enableDrawing = true;
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

        private void OnDrawGizmos()
        {
            if (_enableDrawing)
            {
                foreach (var shape in _shapes)
                {
                    shape.Draw();
                }
            }
        }
    }
}
