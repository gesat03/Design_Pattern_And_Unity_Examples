namespace TowerDefenceExample
{
    public class CannonFirstLevel : IFirstLevel
    {
        public ETowerLevel GetLevel()
        {
            return ETowerLevel.First;
        }
    }
}
