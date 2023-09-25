using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonIdleState : ITIdleState
    {
        public void IdleState()
        {
            Debug.Log("Cannon detects no enemy");
        }

    }
}
