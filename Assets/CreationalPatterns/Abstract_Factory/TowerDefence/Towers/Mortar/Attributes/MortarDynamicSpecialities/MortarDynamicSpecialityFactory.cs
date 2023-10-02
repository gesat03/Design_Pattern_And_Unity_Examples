using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarDynamicSpecialityFactory : ITDynamicSpecialities
    {
        public ITDamage TowerDamage()
        {
            return new MortarDamage();
        }

        public ITDetectRange TowerDetectRange()
        {
            return new MortarDetectRange();
        }

        public ITFireRate TowerFireRate()
        {
            return new MortarFireRate();
        }
    }
}
