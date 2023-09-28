using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TowerDefenceExample
{
    public class TowerDefenceTest : MonoBehaviour
    {
        public Dropdown TowerTypeDropDown;

        private ETowerTypes _towerType;
        private BaseTower _currentTower;
        private BaseTowerFactory _generateTower;

        //public ETowerTypes TowerType;


        private void Start()
        {
            _generateTower = new TowerFactory();

            _towerType = ETowerTypes.Cannon;

            //BaseTowerFactory GenerateTower = new TowerFactory();

            //BaseTower CurrentTower = GenerateTower.GetTower(_towerType);

            //CurrentTower.MakeFireAnimation();
        }

        public void SelectTower()
        {
            _towerType = (ETowerTypes)TowerTypeDropDown.value;

            _currentTower = _generateTower.GetTower(_towerType);

            Debug.Log(_towerType);
        }

        public void FireAnimationTest()
        {
            _currentTower.MakeFireAnimation();
        }

        public void DetectTest()
        {
            _currentTower.EnemyDetected();
        }

        public void DamageTest()
        {
            _currentTower.ApplyingDamage();
        }

        public void GetRangeTest()
        {
            _currentTower.GetRadarRange();
        }

        public void GetFireRateTest()
        {
            _currentTower.GetFireRate();
        }

        public void IdleAnimationTest()
        {
            _currentTower.NoEnemyDetection();
        }

    }
}
