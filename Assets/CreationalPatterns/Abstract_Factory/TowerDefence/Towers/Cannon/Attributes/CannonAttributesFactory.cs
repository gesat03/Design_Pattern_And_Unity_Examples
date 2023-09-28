namespace TowerDefenceExample
{
    public class CannonAttributesFactory : ITAttributes
    {
        public ITAnimations TowerAnimations()
        {
            return new CannonAnimationsFactory();
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
    }
}
