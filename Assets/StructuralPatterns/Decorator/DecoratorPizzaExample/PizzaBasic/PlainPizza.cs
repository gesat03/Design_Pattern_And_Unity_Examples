using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class PlainPizza : IPizza
    {
        public float Cost()
        {
            return 4.00f;
        }

        public string GetDescription()
        {
            return "Thin dough";
        }
    }
}
