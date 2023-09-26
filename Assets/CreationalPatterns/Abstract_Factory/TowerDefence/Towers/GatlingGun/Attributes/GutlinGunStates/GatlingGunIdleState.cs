using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunIdleState : ITIdleState
    {
        public void IdleState()
        {
            Debug.Log("Gatlinggun in idle state...");
        }
    }
}
