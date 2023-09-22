using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public abstract class BaseEnemyShipBuilding
    {
        // This acts as an ordering mechanism for creating
        // EnemyShips that have a weapon, engine & name
        // & nothing else

        // The specific parts used for engine & weapon depend
        // upon the string that is passed to this method

        protected abstract BaseEnemyShip MakeEnemyShip(TypesOfShip typeOfShip);

        // When called a new EnemyShip is made. The specific parts
        // are based on the string entered. After the ship is made
        // we execute multiple methods in the EnemyShip Object

        public BaseEnemyShip OrderTheShip(TypesOfShip typeOfShip)
        {
            BaseEnemyShip theEnemyShip = MakeEnemyShip(typeOfShip);

            theEnemyShip.MakeShip();
            theEnemyShip.ShowMessage();
            theEnemyShip.DisplayEnemyShip();
            theEnemyShip.ActivateForceField();
            theEnemyShip.FollowHeroShip();
            theEnemyShip.EnemyShipShoots();

            return theEnemyShip;
        }


    }
}
