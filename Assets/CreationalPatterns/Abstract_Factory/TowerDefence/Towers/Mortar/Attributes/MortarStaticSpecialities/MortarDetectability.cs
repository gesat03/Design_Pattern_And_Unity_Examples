using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarDetectability : ITDetectability
    {
        public bool Air()
        {
            return false;
        }

        public bool Ground()
        {
            return true;
        }

        public bool Water()
        {
            return false;
        }
    }
}
