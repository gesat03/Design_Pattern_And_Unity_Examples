using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerIdleState : ITIdleState
    {
        public void GetState()
        {
            Debug.Log("Shocker on standby...");
        }
    }
}
