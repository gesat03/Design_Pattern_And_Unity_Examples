namespace TowerDefenceExample
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
            _TowerState = _towerAttributes.TowerStates();
            _TowerAnimations = _towerAttributes.TowerAnimations();
            _TowerLevels = _towerAttributes.TowerLevels();
            _TowerSpecialities = _towerAttributes.TowerSpecialities();
        }

    }
}
