using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonAnimationsFactory : ITAnimations
    {
        public IFiringAnimation FiringAnimation()
        {
            return new CannonFiringAnimation();
        }
    }
}
