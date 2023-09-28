namespace TowerDefenceExample
{
    public class CannonDynamicSpecialityFactory : ITDynamicSpecialities
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
