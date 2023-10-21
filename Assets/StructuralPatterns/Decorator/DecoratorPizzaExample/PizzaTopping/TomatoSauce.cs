using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class TomatoSauce : ToppingDecoratorBase
    {
        float _cost = 0.55f;

        public TomatoSauce(IPizza pizza) : base(pizza)
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded tomato sauce - with cost of: " + _cost;
        }
    }
}
