using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerDynamicSpecialityFactory : ITDynamicSpecialities
    {
        public ITDamage TowerDamage()
        {
            return new ShockerDamage();
        }

        public ITDetectRange TowerDetectRange()
        {
            return new ShockerDetectRange();
        }

        public ITFireRate TowerFireRate()
        {
            return new ShockerFireRate();
        }
    }
}
