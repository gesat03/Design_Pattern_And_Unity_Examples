using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherAnimationsFactory : ITAnimations
    {
        public IFiringAnimation FiringAnimation()
        {
            return new MissileLauncherFiringAnimation();
        }
    }
}
