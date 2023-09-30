using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherFirstLevel : ITFirstLevel
    {
        public ETowerLevel GetLevel()
        {
            return ETowerLevel.First;
        }
    }
}
