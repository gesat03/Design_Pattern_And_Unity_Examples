using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherLevelFactory : ITLevels
    {
        public ITFirstLevel TowerLevel()
        {
            return new MissileLauncherFirstLevel();
        }
    }
}
