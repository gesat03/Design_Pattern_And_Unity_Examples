namespace TowerDefenceExample
{
    public class GatlingGunDynamicSpecialityFactory : ITDynamicSpecialities
    {
        public ITDamage TowerDamage()
        {
            return new GatlingGunDamage();
        }

        public ITDetectRange TowerDetectRange()
        {
            return new GatlingGunDetectRange();
        }

        public ITFireRate TowerFireRate()
        {
            return new GatlingGunFireRate();
        }
    }
}
