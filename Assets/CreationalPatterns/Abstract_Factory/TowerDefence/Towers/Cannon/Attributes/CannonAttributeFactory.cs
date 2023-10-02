namespace TowerDefenceExample
{
    public class CannonAttributeFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new CannonAnimationFactory();
        }

        public ITLevels TowerLevels()
        {
            return new CannonLevelFactory();
        }

        public ITDynamicSpecialities TowerDynamicSpecialities()
        {
            return new CannonDynamicSpecialityFactory();
        }

        public ITStates TowerStates()
        {
            return new CannonStateFactory();
        }

        public ITStaticSpecialities TowerStaticSpecialities()
        {
            return new CannonStaticSpecialityFactory();
        }
    }
}
