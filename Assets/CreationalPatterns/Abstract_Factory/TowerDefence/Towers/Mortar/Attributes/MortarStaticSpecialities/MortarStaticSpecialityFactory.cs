using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarStaticSpecialityFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new MortarDetectability();
        }
    }
}
