using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonFiringAnimation : IFiringAnimation
    {
        public void MakeAnimation()
        {
            Debug.Log("Cannon is bombarding");
        }
    }
}
