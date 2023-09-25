namespace TowerDefenceExample
{
    public class CannonSpecialitiesFactory : ITSpecialities
    {
        public ITDamage TowerDamage()
        {
            return new CannonDamage();
        }

        public ITDetectRange TowerDetectRange()
        {
            return new CannonDetectRange();
        }

        public ITFireRate TowerFireRate()
        {
            return new CannonFireRate();
        }
    }
}
