using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonDetectedState : ITDetectedState
    {
        public void DetectedState()
        {
            Debug.Log("Cannon detect ENEMY vehicle !!!!!");
        }

    }
}
