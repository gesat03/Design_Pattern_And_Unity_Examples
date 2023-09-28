namespace TowerDefenceExample
{
    public class CannonTower : BaseTower
    {
        ITAttributes _towerAttributes;

        public CannonTower(ITAttributes towerAttributes)
        {
            _towerAttributes = towerAttributes;
        }

        public override void CreateTower()
        {
            _Name = ETowerTypes.Cannon.ToString();
            _TowerState = _towerAttributes.TowerStates();
            _TowerAnimations = _towerAttributes.TowerAnimations();
            _TowerLevels = _towerAttributes.TowerLevels();
            _TowerDynamicSpecialities = _towerAttributes.TowerDynamicSpecialities();
        }
    }
}
