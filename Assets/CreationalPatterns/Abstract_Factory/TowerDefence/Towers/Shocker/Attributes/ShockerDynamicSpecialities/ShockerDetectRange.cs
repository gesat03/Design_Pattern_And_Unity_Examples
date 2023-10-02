using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerDetectRange : ITDetectRange
    {
        public Vector2 DetectRange()
        {
            return new Vector2(0.5f, 0.5f);
        }
    }
}
