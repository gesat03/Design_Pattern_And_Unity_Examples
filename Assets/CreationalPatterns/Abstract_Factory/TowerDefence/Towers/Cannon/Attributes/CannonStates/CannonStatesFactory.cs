using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonStatesFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new CannonDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new CannonIdleState();
        }

    }
}
