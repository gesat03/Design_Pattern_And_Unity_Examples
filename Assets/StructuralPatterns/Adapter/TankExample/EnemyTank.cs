using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankExample
{
    public class EnemyTank : IEnemyAttacker
    {
        public void AssignDriver(string driverName)
        {
            Debug.Log(driverName + " driving the tank...");
        }

        public void DriveForward()
        {
            Debug.Log("Enemy tank drives forward");
        }

        public void FireWeapon()
        {
            Debug.Log("Enemy tank does 100 damage");
        }
    }
}
