using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherFireRate : ITFireRate
    {
        public float FireRate()
        {
            return 2.0f;
        }
    }
}
