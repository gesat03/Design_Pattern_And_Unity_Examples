
namespace Assets.GurkansSandBox.StrategyPattern.Animals
{
	public class Animal
	{
		IFlyingType FlyingType;

		public string TryToFly()
        {
			return FlyingType.Fly();
		}

		public void SetFlyingAbility(IFlyingType newFlyingType)
        {
			FlyingType = newFlyingType;
        }

	}
}
