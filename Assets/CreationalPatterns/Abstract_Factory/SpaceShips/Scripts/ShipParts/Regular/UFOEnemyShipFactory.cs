using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    // This factory uses the EnemyShipFactory interface
    // to create very specific UFO Enemy Ship

    // This is where we define all of the parts the ship
    // will use by defining the methods implemented
    // being ESWeapon and ESEngine

    // The returned object specifies a specific weapon & engine
    public class UFOEnemyShipFactory : IEnemyShipFactory
    {
        // Defines the weapon object to associate with the ship
        public IESEngine AddESEngine()
        {
            return new ESUFOEngine();
        }

        public IESForceField AddESForceField()
        {
            return new ESUFOForceField();
        }

        // Defines the engine object to associate with the ship
        public IESWeapon AddESGun()
        {
            return new ESUFOGun();
        }

    }
}
