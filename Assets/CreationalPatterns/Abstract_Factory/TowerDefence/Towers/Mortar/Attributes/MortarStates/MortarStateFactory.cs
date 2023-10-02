using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarStateFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new MortarDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new MortarIdleState();
        }
    }
}
