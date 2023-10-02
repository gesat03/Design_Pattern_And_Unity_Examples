using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarDetectRange : ITDetectRange
    {
        public Vector2 DetectRange()
        {
            return new Vector2(5f, 5f);
        }
    }
}
