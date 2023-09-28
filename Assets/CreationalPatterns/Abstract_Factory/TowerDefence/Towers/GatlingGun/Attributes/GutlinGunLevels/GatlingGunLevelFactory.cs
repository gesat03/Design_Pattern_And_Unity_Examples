namespace TowerDefenceExample
{
    public class GatlingGunLevelFactory : ITLevels
    {
        public IFirstLevel TowerLevel()
        {
            return new GatlingGunFirstLevel();
        }
    }
}
