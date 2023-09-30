using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherDynamicSpecialitiesFactory : ITDynamicSpecialities
    {
        public ITDamage TowerDamage()
        {
            return new MissileLauncherDamage();
        }

        public ITDetectRange TowerDetectRange()
        {
            return new MissileLauncherDetectRange();
        }

        public ITFireRate TowerFireRate()
        {
            return new MissileLauncherFireRate();
        }
    }
}
