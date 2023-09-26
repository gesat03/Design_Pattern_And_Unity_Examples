using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonAttributesFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new CannonAnimationsFactory();
        }

        public ITLevel TowerLevels()
        {
            return new CannonLevelFactory();
        }

        public ITSpecialities TowerSpecialities()
        {
            return new CannonSpecialityFactory();
        }

        public ITStates TowerStates()
        {
            return new CannonStateFactory();
        }
    }
}