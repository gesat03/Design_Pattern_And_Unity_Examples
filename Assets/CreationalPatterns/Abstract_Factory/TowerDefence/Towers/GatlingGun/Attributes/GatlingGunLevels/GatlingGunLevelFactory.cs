namespace TowerDefenceExample
{
    public class GatlingGunLevelFactory : ITLevels
    {
        public ITFirstLevel TowerLevel()
        {
            return new GatlingGunFirstLevel();
        }
    }
}
