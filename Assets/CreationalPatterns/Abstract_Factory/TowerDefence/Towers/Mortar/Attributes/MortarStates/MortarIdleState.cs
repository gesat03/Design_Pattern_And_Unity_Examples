using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarIdleState : ITIdleState
    {
        public void GetState()
        {
            Debug.Log("Mortar in stand by...");
        }
    }
}
