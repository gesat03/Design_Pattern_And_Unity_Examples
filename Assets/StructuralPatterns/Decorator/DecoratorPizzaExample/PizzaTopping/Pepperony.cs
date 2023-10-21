using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Pepperony : ToppingDecoratorBase
    {
        float _cost = 0.15f;

        public Pepperony(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded slice of pepperony - with cost of: " + _cost;
        }
    }
}
