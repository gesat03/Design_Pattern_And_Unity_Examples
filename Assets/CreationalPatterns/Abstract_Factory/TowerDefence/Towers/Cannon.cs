namespace TowerDefenceExample
{
    public class Cannon : BaseTower
    {
        ITAttributes _towerAttributes;

        public Cannon(ITAttributes towerAttributes)
        {
            _towerAttributes = towerAttributes;
        }

        public override void CreateTower()
        {
            _TowerState = _towerAttributes.CurrentState();
            _TowerAnimations = _towerAttributes.CurrentAnimation();
            _TowerLevels = _towerAttributes.CurrentLevel();
            _TowerDamage = _towerAttributes.GetDamage();
            _TowerDetectRange = _towerAttributes.GetRange();
            _TowerFireRate = _towerAttributes.GetFireRate();
        }
    }
}
