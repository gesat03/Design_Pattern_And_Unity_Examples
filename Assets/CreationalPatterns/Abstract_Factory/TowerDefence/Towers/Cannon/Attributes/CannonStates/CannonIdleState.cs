using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonIdleState : ITIdleState
    {
        public void GetState()
        {
            Debug.Log("Cannon detects no enemy");
        }

    }
}
