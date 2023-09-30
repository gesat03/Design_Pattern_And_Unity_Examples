using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherStateFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new MissileLauncherDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new MissileLauncherIdleState();
        }
    }
}
