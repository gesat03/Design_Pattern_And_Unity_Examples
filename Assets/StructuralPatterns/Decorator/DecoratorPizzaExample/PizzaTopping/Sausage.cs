using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Sausage : ToppingDecoratorBase
    {
        float _cost = 1.15f;

        public Sausage(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded best grade sausage - with cost of: " + _cost;
        }
    }
}
