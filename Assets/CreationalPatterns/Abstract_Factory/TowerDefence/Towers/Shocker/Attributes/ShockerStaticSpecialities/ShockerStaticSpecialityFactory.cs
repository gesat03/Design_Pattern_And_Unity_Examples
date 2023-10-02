using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerStaticSpecialityFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new ShockerDetectability();
        }
    }
}
