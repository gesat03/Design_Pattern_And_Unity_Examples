using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonStaticSpecialitiesFactory : ITStaticSpecialities
    {
        public ITDetectability Detectablity()
        {
            return new CannonDetectability();
        }
    }
}
