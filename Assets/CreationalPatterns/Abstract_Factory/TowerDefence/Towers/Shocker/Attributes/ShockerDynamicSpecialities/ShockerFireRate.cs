using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerFireRate : ITFireRate
    {
        public float FireRate()
        {
            return 5f;
        }
    }
}
