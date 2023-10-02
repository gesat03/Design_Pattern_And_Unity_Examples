using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarFirstLevel : ITFirstLevel
    {
        public ETowerLevel GetLevel()
        {
            return ETowerLevel.First;
        }
    }
}
