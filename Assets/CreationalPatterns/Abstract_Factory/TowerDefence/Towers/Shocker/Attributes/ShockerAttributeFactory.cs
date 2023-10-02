using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerAttributeFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new ShockerAnimationFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new ShockerDynamicSpecialityFactory();
        }

        public ITLevels TowerLevels()
        {
            return new ShockerLevelFactory();
        }

        public ITStates TowerStates()
        {
            return new ShockerStateFactory();
        }

        public ITStaticSpecialities TowerStaticSpecialities()
        {
            return new ShockerStaticSpecialityFactory();
        }
    }
}
