namespace TowerDefenceExample
{
    public class GatlingGunAnimationFactory : ITAnimations
    {
        public ITFiringAnimation FiringAnimation()
        {
            return new GatlingGunFiringAnimation();
        }
    }
}
