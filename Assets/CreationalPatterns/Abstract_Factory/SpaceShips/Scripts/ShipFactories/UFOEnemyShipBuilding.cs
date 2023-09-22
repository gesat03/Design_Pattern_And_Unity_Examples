using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public class UFOEnemyShipBuilding : BaseEnemyShipBuilding
    {
        // This is the only class that needs to change, if you
        // want to determine which enemy ships you want to
        // provide as an option to build
        protected override BaseEnemyShip MakeEnemyShip(TypesOfShip typeOfShip)
        {
            BaseEnemyShip theEnemyShip;

            IEnemyShipFactory shipPartsFactory;

            // If UFO was sent grab use the factory that knows
            // what types of weapons and engines a regular UFO
            // needs. The EnemyShip object is returned & given a name
            switch (typeOfShip)
            {
                case TypesOfShip.UFO:
                    shipPartsFactory = new UFOEnemyShipFactory();
                    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                    theEnemyShip.SetName = "UFO Grunt Ship";
                    break;
                case TypesOfShip.Boss:
                    shipPartsFactory = new UFOBossEnemyShipFactory();
                    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                    theEnemyShip.SetName = "UFO Boss Ship";
                    break;
                default:
                    shipPartsFactory = new UFOEnemyShipFactory();
                    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                    theEnemyShip.SetName = "UFO Grunt Ship";
                    break;
            }

            return theEnemyShip;
        }
    }
}
