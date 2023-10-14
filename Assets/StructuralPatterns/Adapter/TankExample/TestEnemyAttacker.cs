using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankExample
{
    public class TestEnemyAttacker : MonoBehaviour
    {

        private void Start()
        {
            EnemyTank Tiger = new EnemyTank();

            EnemyRobot B166ER = new EnemyRobot();

            IEnemyAttacker robotAdapter = new EnemyRobotAdapter(B166ER);

            Debug.Log("The Robot name is B166ER");
            B166ER.WalkForward();
            B166ER.ReactToHuman("George");
            B166ER.SmashWithHands();

            Debug.Log("The Enemy tank is Tiger");
            Tiger.DriveForward();
            Tiger.AssignDriver("George");
            Tiger.FireWeapon();

            Debug.Log("The Robot Adapter B166ER");
            robotAdapter.DriveForward();
            robotAdapter.AssignDriver("George");
            robotAdapter.FireWeapon();
        }

    }
}
