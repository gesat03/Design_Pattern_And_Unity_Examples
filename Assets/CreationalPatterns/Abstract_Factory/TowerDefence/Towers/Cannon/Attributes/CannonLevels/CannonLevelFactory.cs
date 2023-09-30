namespace TowerDefenceExample
{
    public class CannonLevelFactory : ITLevels
    {
        public ITFirstLevel TowerLevel()
        {
            return new CannonFirstLevel();
        }
    }
}
