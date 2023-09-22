using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    // Any part that implements the interface ESWeapon
    // can replace that part in any ship
    public interface IESWeapon
    {
        // User is forced to implement this method
        // It outputs the string returned when the 
        // object is printed

        public string ShowMessage();
    }
}
