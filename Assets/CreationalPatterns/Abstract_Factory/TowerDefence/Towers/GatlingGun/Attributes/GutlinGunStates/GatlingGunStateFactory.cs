using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunStateFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new GatlingGunDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new GatlingGunIdleState();
        }
    }
}
