namespace TowerDefenceExample
{
    public class CannonAnimationFactory : ITAnimations
    {
        public ITFiringAnimation FiringAnimation()
        {
            return new CannonFiringAnimation();
        }
    }
}
