using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunDetectability : ITDetectability
    {
        public bool Air()
        {
            return true;
        }

        public bool Ground()
        {
            return true;
        }

        public bool Water()
        {
            return true;
        }
    }
}
