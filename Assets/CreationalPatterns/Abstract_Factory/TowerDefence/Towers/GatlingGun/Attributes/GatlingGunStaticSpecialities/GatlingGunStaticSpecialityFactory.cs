using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunStaticSpecialityFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new GatlingGunDetectability();
        }

    }
}
