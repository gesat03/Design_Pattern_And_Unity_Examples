using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public class EnemyShipTesting : MonoBehaviour
    {
        private void Start()
        {
            // EnemyShipBuilding handles orders for new EnemyShips
            // You send it a code using the orderTheShip method &
            // it sends the order to the right factory for creation

            BaseEnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();

            Debug.Log("The Grunt...." + "\n");
            BaseEnemyShip theGrunt = MakeUFOs.OrderTheShip(TypesOfShip.UFO);

            Debug.Log("The Boss..." + "\n");
            BaseEnemyShip theBoss = MakeUFOs.OrderTheShip(TypesOfShip.Boss);

        }
    }
}
