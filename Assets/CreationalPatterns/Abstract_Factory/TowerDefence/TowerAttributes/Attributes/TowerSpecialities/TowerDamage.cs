using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerDamage : ITSpecialities<int>
    {
        int _damage;

        public TowerDamage(int setDamage)
        {
            _damage = setDamage;
        }

        public int GetValue()
        {
            return _damage;
        }
    }
}
