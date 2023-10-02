using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherAttributeFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new MissileLauncherAnimationFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new MissileLauncherDynamicSpecialityFactory();
        }

        public ITLevels TowerLevels()
        {
            return new MissileLauncherLevelFactory();
        }

        public ITStates TowerStates()
        {
            return new MissileLauncherStateFactory();
        }

        public ITStaticSpecialities TowerStaticSpecialities()
        {
            return new MissileLauncherStaticSpecialityFactory();
        }
    }
}
