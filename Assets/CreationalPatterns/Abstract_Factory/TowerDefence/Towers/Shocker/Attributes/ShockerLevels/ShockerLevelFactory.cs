using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerLevelFactory : ITLevels
    {
        public ITFirstLevel TowerLevel()
        {
            return new ShockerFirstLevel();
        }
    }
}
