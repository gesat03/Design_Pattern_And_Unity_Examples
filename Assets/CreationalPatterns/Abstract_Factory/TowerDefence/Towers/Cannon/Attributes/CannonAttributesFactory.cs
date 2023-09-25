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
            return new CannonLevelsFactory();
        }

        public ITSpecialities TowerSpecialities()
        {
            return new CannonSpecialitiesFactory();
        }

        public ITStates TowerStates()
        {
            return new CannonStatesFactory();
        }
    }
}
