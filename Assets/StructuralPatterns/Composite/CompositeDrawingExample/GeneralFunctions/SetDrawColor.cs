using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeDrawingExample
{
    public static class SetDrawColor
    {
        public static Color Set(EShapeColor color)
        {
            switch (color)
            {
                case EShapeColor.Red:
                    return Color.red;
                case EShapeColor.Green:
                    return Color.green;
                case EShapeColor.Blue:
                    return Color.blue;
                case EShapeColor.Yellow:
                    return Color.yellow;
                case EShapeColor.White:
                    return Color.white;
                case EShapeColor.Black:
                    return Color.black;
                default:
                    return Color.white;
            }
        }
    }
}
