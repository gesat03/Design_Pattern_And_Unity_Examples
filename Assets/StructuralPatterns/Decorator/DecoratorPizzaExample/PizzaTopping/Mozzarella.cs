using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Mozzarella : ToppingDecoratorBase
    {
        float _cost = 0.75f;

        public Mozzarella(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded mozzarella - with cost of: " + _cost;
        }
    }
}
