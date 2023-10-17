using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace CompositeDrawingExample
{
    public class DrawingTest : MonoBehaviour
    {
        DrawingComposite _drawing;

        void Start()
        {
            _drawing = gameObject.AddComponent<DrawingComposite>();

            Triangle triangle = new Triangle(EShapeColor.Red, 1f);
            Circle circle = new Circle(EShapeColor.Green, 1.5f);
            Square square = new Square(EShapeColor.Blue, 2f);

            _drawing.Add(triangle);
            _drawing.Add(square);
            _drawing.Add(circle);

            _drawing.Draw();

            StartCoroutine(DrawWithDelay(1.5f));

            IEnumerator DrawWithDelay(float time)
            {
                yield return new WaitForSeconds(time);
                _drawing.Remove(circle);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Remove(square);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Remove(triangle);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Add(triangle);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Add(square);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Add(circle);
                _drawing.Draw();
                yield return new WaitForSeconds(time);
                _drawing.Clear();
                _drawing.Draw();
            }
        }

        void taskExample()
        {
            //tasks.Add(RemoveCircle());
            //tasks.Add(RemoveSquare());
            //tasks.Add(RemoveTriangle());
            //tasks.Add(AddTriangle());
            //tasks.Add(AddSquare());
            //tasks.Add(AddCircle());
            //tasks.Add(RemoveAll());

            //async Task RemoveCircle()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Remove(circle);
            //    _drawing.Draw();
            //}
            //async Task RemoveSquare()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Remove(square);
            //    _drawing.Draw();
            //}
            //async Task RemoveTriangle()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Remove(triangle);
            //    _drawing.Draw();
            //}
            //async Task AddTriangle()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Add(triangle);
            //    _drawing.Draw();
            //}
            //async Task AddSquare()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Add(square);
            //    _drawing.Draw();
            //}
            //async Task AddCircle()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Add(circle);
            //    _drawing.Draw();
            //}
            //async Task RemoveAll()
            //{
            //    await Task.Delay(2000);
            //    _drawing.Clear();
            //    _drawing.Draw();
            //}
        }

    }
}
