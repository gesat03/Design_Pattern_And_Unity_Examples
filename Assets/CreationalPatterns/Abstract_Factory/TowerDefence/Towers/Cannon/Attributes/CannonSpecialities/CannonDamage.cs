using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonDamage : ITDamage
    {
        public int Damage()
        {
            return 20;
        }
    }
}
