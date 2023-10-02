using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherStaticSpecialityFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new MissileLauncherDetectability();
        }
    }
}
