using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankExample
{
    public class EnemyRobot : MonoBehaviour
    {
        
        public void SmashWithHands()
        {
            Debug.Log("Enemy Robot smashing....");
        }

        public void WalkForward()
        {
            Debug.Log("Enemy Robot marching forward!");
        }

        public void ReactToHuman(string driverName)
        {
            Debug.Log("Enemy robot captured " + driverName);
        }

    }
}
