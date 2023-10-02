using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerStateFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new ShockerDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new ShockerIdleState();
        }
    }
}
