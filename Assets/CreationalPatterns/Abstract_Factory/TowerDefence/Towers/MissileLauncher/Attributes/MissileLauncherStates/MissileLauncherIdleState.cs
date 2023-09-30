using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherIdleState : ITIdleState
    {
        public void GetState()
        {
            Debug.Log("Missile Launcher on Idle State. There is no enemy arround");
        }
    }
}
