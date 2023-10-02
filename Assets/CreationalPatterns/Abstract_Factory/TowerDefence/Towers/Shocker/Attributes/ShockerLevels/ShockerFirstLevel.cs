using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerFirstLevel : ITFirstLevel
    {
        public ETowerLevel GetLevel()
        {
            return ETowerLevel.First;
        }
    }
}
