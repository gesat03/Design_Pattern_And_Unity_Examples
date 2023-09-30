using UnityEngine;

namespace TowerDefenceExample
{
    public interface ITAttributes
    {
        public ITStates TowerStates();

        public ITAnimations TowerAnimations();

        public ITLevels TowerLevels();

        public ITDynamicSpecialities TowerDynamicSpecialities();

        public ITStaticSpecialities TowerStaticSpecialities();

    }
}
