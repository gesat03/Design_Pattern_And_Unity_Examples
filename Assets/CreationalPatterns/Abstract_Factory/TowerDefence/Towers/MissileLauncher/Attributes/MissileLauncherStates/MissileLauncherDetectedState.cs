using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherDetectedState : ITDetectedState
    {
        public void GetState()
        {
            Debug.Log("Missile Launcher detect ENEMY!!!");
        }
    }
}
