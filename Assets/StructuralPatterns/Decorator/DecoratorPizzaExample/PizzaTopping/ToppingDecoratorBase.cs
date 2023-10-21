using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class ToppingDecoratorBase : IPizza
    {
        protected IPizza _pizza;

        public ToppingDecoratorBase(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual float Cost()
        {
            return _pizza.Cost();
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
