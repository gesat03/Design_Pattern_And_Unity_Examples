namespace TowerDefenceExample
{
    public class GatlingGunAnimationsFactory : ITAnimations
    {
        public IFiringAnimation FiringAnimation()
        {
            return new GatlingGunFiringAnimation();
        }
    }
}
