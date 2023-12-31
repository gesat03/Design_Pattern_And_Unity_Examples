﻿namespace TowerDefenceExample
{
    public class GatlingGunTower : BaseTower
    {
        ITAttributes _towerAttributes;

        public GatlingGunTower(ITAttributes towerAttributes)
        {
            _towerAttributes = towerAttributes;
        }

        public override void CreateTower()
        {
            _Name = ETowerTypes.GatlingGun.ToString();
            _TowerStates = _towerAttributes.TowerStates();
            _TowerAnimations = _towerAttributes.TowerAnimations();
            _TowerLevels = _towerAttributes.TowerLevels();
            _TowerDynamicSpecialities = _towerAttributes.TowerDynamicSpecialities();
            _TowerStaticSpecialities = _towerAttributes.TowerStaticSpecialities();
        }
    }
}
