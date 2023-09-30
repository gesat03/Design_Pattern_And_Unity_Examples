using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherDamage : ITDamage
    {
        public int Damage()
        {
            return 5;
        }
    }
}
