using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonLevelFactory : ITLevel
    {
        public FirstLevel TowerLevel()
        {
            return new CannonFirstLevel();
        }
    }
}
