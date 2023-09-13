using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public class UFOEnemyShip : BaseEnemyShip
    {
        // We define the type of ship we want to create
        // by stating we want to use the factory that 
        // makes enemy ships
        IEnemyShipFactory _shipFactory;

        // The enemy ship required parts list is sent to 
        // this method. They state that the enemy ship
        // must have a weapon and engine assigned. That 
        // object also states the specific parts needed
        // to make a regular UFO versus a Boss UFO
        public UFOEnemyShip(IEnemyShipFactory shipFactory)
        {
            _shipFactory = shipFactory;
        }

        // EnemyShipBuilding calls this method to build a 
        // specific UFOEnemyShip
        public override void MakeShip()
        {
            Debug.Log("Making enemy ship " + GetName);

            // The specific weapon & engine needed were passed in
            // shipFactory. We are assigning those specific part
            // objects to the UFOEnemyShip here
            weapon = _shipFactory.AddESGun();
            engine = _shipFactory.AddESEngine();
            forceField = _shipFactory.AddESForceField();
        }


    }
}
