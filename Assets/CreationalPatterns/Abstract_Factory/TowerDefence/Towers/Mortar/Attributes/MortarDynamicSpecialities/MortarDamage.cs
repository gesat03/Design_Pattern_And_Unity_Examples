using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarDamage : ITDamage
    {
        public int Damage()
        {
            return 25;
        }
    }
}
