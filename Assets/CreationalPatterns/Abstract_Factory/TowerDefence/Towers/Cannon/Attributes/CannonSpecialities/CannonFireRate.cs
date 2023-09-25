using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonFireRate : ITFireRate
    {
        public float FireRate()
        {
            return 3.0f;
        }

    }
}
