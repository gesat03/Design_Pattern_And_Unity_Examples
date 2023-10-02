using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarAnimationFactory : ITAnimations
    {
        public ITFiringAnimation FiringAnimation()
        {
            return new MortarFiringAnimation();
        }
    }
}
