using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherStaticSpecialitiesFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new MissileLauncherDetectability();
        }
    }
}
