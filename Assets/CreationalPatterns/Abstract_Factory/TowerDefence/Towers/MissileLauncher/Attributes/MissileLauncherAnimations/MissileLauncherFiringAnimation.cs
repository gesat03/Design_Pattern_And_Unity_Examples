using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MissileLauncherFiringAnimation : ITFiringAnimation
    {
        public void MakeAnimation()
        {
            Debug.Log("Missile lunched !!!");
        }
    }
}
