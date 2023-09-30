using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherFiringAnimation : IFiringAnimation
    {
        public void MakeAnimation()
        {
            Debug.Log("Missile lunched !!!");
        }
    }
}
