using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunAttributesFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new GatlingGunAnimationsFactory();
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
            return new GatlingGunStaticSpecialitiesFactory();
        }
    }
}
