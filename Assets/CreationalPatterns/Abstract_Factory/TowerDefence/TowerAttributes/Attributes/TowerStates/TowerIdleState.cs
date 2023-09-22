using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerIdleState : ITStates
    {
        public void TowerState()
        {
            Debug.Log("Tower is in stand by position...");
        }

    }
}
