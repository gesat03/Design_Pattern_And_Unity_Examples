using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunIdleState : ITIdleState
    {
        public void GetState()
        {
            Debug.Log("Gatling gun in idle state...");
        }
    }
}
