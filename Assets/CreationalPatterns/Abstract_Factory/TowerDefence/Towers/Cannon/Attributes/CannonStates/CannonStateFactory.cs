namespace TowerDefenceExample
{
    public class CannonStateFactory : ITStates
    {
        public ITDetectedState TowerDetectState()
        {
            return new CannonDetectedState();
        }

        public ITIdleState TowerIdleState()
        {
            return new CannonIdleState();
        }

    }
}
