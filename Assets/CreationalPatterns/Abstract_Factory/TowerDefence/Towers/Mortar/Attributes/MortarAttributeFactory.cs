using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarAttributeFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new MortarAnimationFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new MortarDynamicSpecialityFactory();
        }

        public ITLevels TowerLevels()
        {
            return new MortarLevelFactory();
        }

        public ITStates TowerStates()
        {
            return new MortarStateFactory();
        }

        public ITStaticSpecialities TowerStaticSpecialities()
        {
            return new MortarStaticSpecialityFactory();
        }
    }
}
