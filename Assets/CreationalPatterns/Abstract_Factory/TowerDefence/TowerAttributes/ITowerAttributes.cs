using UnityEngine;

namespace TowerDefenceExample
{
    public interface ITAttributes
    {
        public ITStates CurrentState();

        public ITAnimations CurrentAnimation();

        public ITLevel CurrentLevel();

        public ITSpecialities<int> GetDamage();
        public ITSpecialities<float> GetFireRate();
        public ITSpecialities<Vector2> GetRange();

    }
}
