using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonLevelsFactory : ITLevel
    {
        public FirstLevel TowerLevel()
        {
            return new CannonFirstLevel();
        }
    }
}
