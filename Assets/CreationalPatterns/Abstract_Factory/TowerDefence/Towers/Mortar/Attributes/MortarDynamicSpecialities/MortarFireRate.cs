using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarFireRate : ITFireRate
    {
        public float FireRate()
        {
            return 5f;
        }
    }
}
