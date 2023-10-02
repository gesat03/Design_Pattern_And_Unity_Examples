using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class ShockerTower : BaseTower
    {
        ITAttributes _towerAttributes;

        public ShockerTower(ITAttributes towerAttributes)
        {
            _towerAttributes = towerAttributes;
        }

        public override void CreateTower()
        {
            _Name = ETowerTypes.Shocker.ToString();
            _TowerStates = _towerAttributes.TowerStates();
            _TowerAnimations = _towerAttributes.TowerAnimations();
            _TowerLevels = _towerAttributes.TowerLevels();
            _TowerDynamicSpecialities = _towerAttributes.TowerDynamicSpecialities();
            _TowerStaticSpecialities = _towerAttributes.TowerStaticSpecialities();
        }
    }
}
