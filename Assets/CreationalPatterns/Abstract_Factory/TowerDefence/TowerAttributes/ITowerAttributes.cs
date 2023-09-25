using UnityEngine;

namespace TowerDefenceExample
{
    public interface ITAttributes
    {
        public ITStates TowerStates();

        public ITAnimations TowerAnimations();

        public ITLevel TowerLevels();

        public ITSpecialities TowerSpecialities();

    }
}
