using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerFactory : BaseTowerFactory
    {
        protected override BaseTower SelectTower(ETowerTypes towerType)
        {
            BaseTower baseTower;

            ITAttributes attributes;

            switch (towerType)
            {
                case ETowerTypes.Cannon:
                    attributes = new CannonAttributesFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
                case ETowerTypes.GatlingGun:
                    attributes = new GatlingGunAttributesFactory();
                    baseTower = new GatlingGunTower(attributes);
                    return baseTower;
                case ETowerTypes.MissileLauncher:
                    attributes = new MissileLauncherAttributesFactory();
                    baseTower = new MissileLauncherTower(attributes);
                    return baseTower;
                case ETowerTypes.Mortar:
                    attributes = new CannonAttributesFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
                case ETowerTypes.Shocker:
                    attributes = new CannonAttributesFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
                default:
                    attributes = new CannonAttributesFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
            }
        }
    }
}
