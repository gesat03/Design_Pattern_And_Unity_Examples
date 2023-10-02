using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarLevelFactory : ITLevels
    {
        public ITFirstLevel TowerLevel()
        {
            return new MortarFirstLevel();
        }
    }
}
