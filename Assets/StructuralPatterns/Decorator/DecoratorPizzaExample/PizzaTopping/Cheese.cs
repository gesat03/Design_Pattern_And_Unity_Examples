using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Cheese : ToppingDecoratorBase
    {
        float _cost = 0.65f;

        public Cheese(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded thin cheese - with cost of: " + _cost;
        }
    }
}
