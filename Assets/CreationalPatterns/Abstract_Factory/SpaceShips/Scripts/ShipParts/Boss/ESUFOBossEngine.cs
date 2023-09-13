using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    // Here we define a basic component of a space ship
    // Any part that implements the interface ESEngine
    // can replace that part in any ship
    public class ESUFOBossEngine : IESEngine
    {
        // EnemyShip contains a reference to the object
        // ESWeapon. It is stored in the field weapon

        // The Strategy design pattern is being used here

        // When the field that is of type ESUFOBossEngine is printed 
        // the following shows on the screen
        public string ShowMessage()
        {
            return "2000 mph";
        }
    }
}
