using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class ToppingDecoratorBase : IPizza
    {
        protected IPizza TempPizza;

        public ToppingDecoratorBase(IPizza pizza)
        {
            TempPizza = pizza;
        }

        public virtual float Cost()
        {
            return TempPizza.Cost();
        }

        public virtual string GetDescription()
        {
            return TempPizza.GetDescription();
        }
    }
}
