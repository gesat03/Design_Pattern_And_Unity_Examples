using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherAttributesFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new MissileLauncherAnimationsFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new MissileLauncherDynamicSpecialitiesFactory();
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
            return new MissileLauncherStaticSpecialitiesFactory();
        }
    }
}
