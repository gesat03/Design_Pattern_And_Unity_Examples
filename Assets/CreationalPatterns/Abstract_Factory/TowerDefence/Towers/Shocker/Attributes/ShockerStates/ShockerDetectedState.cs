using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerDetectedState : ITDetectedState
    {
        public void GetState()
        {
            Debug.Log("Shocker detects ENEMY vehicle");
        }
    }
}
