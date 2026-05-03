
namespace Assets.GurkansSandBox.StrategyPattern.Animals
{
    public class Bird : Animal
    {
        public Bird()
        {
            SetFlyingAbility(new ItFlys());
        }
    }
}
