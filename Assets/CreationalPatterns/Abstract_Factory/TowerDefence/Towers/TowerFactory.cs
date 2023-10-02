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
                    attributes = new CannonAttributeFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
                case ETowerTypes.GatlingGun:
                    attributes = new GatlingGunAttributeFactory();
                    baseTower = new GatlingGunTower(attributes);
                    return baseTower;
                case ETowerTypes.MissileLauncher:
                    attributes = new MissileLauncherAttributeFactory();
                    baseTower = new MissileLauncherTower(attributes);
                    return baseTower;
                case ETowerTypes.Mortar:
                    attributes = new MortarAttributeFactory();
                    baseTower = new MortarTower(attributes);
                    return baseTower;
                case ETowerTypes.Shocker:
                    attributes = new ShockerAttributeFactory();
                    baseTower = new ShockerTower(attributes);
                    return baseTower;
                default:
                    attributes = new CannonAttributeFactory();
                    baseTower = new CannonTower(attributes);
                    return baseTower;
            }
        }
    }
}
