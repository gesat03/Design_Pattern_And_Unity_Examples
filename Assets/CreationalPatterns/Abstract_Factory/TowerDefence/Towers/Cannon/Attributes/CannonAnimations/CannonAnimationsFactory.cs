namespace TowerDefenceExample
{
    public class CannonAnimationsFactory : ITAnimations
    {
        public IFiringAnimation FiringAnimation()
        {
            return new CannonFiringAnimation();
        }
    }
}
