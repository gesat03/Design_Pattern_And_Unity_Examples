using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarDetectedState : ITDetectedState
    {
        public void GetState()
        {
            Debug.Log("Mortar detects the target...");
        }
    }
}
