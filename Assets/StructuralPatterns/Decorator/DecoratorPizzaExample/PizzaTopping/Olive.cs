using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Olive : ToppingDecoratorBase
    {
        float _cost = 0.35f;

        public Olive(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded few olive - with cost of: " + _cost;
        }
    }
}
