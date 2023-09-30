using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherDetectRange : ITDetectRange
    {
        public Vector2 DetectRange()
        {
            return new Vector2(1.0f, 1.0f);
        }
    }
}
