namespace TowerDefenceExample
{
    public class CannonFirstLevel : ITFirstLevel
    {
        public ETowerLevel GetLevel()
        {
            return ETowerLevel.First;
        }
    }
}
