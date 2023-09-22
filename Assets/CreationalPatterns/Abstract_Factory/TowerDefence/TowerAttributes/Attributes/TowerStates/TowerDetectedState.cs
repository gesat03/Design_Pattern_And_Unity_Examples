using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerDetectedState : ITStates
    {
        public void TowerState()
        {
            Debug.Log("Enemy DETECTED ...");
        }
    }
}
