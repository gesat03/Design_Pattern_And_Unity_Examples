using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class PlainPizza : IPizza
    {
        float _cost = 4.0f;

        public float Cost()
        {
            return _cost;
        }

        public string GetDescription()
        {
            return "Thin dough - with cost of: " + _cost;
        }
    }
}
