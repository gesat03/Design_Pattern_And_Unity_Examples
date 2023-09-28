using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunDetectedState : ITDetectedState
    {
        public void GetState()
        {
            Debug.Log("Gutling gun DETECTED enemy vehicle !!!");
        }

    }
}
