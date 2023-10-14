using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankExample
{
    public interface IEnemyAttacker
    {
        public void FireWeapon();
        public void DriveForward();
        public void AssignDriver(string driverName);

    }
}
