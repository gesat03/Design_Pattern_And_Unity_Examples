namespace TowerDefenceExample
{
    public class CannonLevelFactory : ITLevels
    {
        public IFirstLevel TowerLevel()
        {
            return new CannonFirstLevel();
        }
    }
}
