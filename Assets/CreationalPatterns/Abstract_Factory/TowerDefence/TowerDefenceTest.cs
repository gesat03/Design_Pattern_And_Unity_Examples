using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerDefenceTest : MonoBehaviour
    {

        private void Start()
        {
            BaseTowerFactory GenerateTower = new TowerFactory();

            BaseTower CannonTower = GenerateTower.GetTower(ETowerTypes.Cannon);

            CannonTower.MakeFireAnimation();
        }

    }
}
