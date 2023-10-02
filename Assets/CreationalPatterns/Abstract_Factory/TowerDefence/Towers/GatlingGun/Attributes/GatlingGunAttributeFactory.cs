using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunAttributeFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new GatlingGunAnimationFactory();
        }

        public ITLevels TowerLevels()
        {
            return new GatlingGunLevelFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new GatlingGunDynamicSpecialityFactory();
        }

        public ITStates TowerStates()
        {
            return new GatlingGunStateFactory();
        }

        public ITStaticSpecialities TowerStaticSpecialities()
        {
            return new GatlingGunStaticSpecialityFactory();
        }
    }
}
