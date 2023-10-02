using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class MortarFiringAnimation : ITFiringAnimation
    {
        public void MakeAnimation()
        {
            Debug.Log("Mortar is launch the BOMB!!!");
        }
    }
}
