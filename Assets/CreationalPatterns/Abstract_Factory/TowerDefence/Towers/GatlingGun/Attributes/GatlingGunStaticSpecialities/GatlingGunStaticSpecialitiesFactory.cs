using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunStaticSpecialitiesFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new GatlingGunDetectability();
        }

    }
}
