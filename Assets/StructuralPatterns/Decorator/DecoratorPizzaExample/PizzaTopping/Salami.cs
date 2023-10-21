using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class Salami : ToppingDecoratorBase
    {
        float _cost = 0.95f;
        
        public Salami(IPizza pizza) : base(pizza) 
        {

        }

        public override float Cost()
        {
            return base.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nadded tick salami - with cost of: " + _cost;
        }
    }
}
