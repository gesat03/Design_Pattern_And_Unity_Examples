using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerDamage : ITDamage
    {
        public int Damage()
        {
            return 50;
        }
    }
}
