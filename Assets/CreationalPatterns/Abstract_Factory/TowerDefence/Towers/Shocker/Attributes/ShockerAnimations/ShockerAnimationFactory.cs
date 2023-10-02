using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerAnimationFactory : ITAnimations
    {
        public ITFiringAnimation FiringAnimation()
        {
            return new ShockerFiringAnimation();
        }
    }
}
