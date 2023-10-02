using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherAnimationFactory : ITAnimations
    {
        public ITFiringAnimation FiringAnimation()
        {
            return new MissileLauncherFiringAnimation();
        }
    }
}
