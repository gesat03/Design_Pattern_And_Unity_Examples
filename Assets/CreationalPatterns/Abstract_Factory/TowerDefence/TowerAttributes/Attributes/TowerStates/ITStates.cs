namespace TowerDefenceExample
{
    public interface ITStates
    {

        public ITIdleState TowerIdleState();

        public ITDetectedState TowerDetectState();

    }
}
