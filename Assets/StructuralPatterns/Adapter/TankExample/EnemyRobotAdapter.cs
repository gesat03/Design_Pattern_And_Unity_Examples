using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankExample
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot _robot;

        public EnemyRobotAdapter(EnemyRobot robot)
        {
            _robot = robot;
        }

        public void AssignDriver(string driverName)
        {
            _robot.ReactToHuman(driverName);
        }

        public void DriveForward()
        {
            _robot.WalkForward();
        }

        public void FireWeapon()
        {
            _robot.SmashWithHands();
        }
    }
}
