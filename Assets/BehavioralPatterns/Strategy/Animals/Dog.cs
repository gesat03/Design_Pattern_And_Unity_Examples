
namespace Assets.GurkansSandBox.StrategyPattern.Animals
{
    public class Dog : Animal
    {
        public Dog()
        {
            SetFlyingAbility(new CantFly());
        }
    }
}
