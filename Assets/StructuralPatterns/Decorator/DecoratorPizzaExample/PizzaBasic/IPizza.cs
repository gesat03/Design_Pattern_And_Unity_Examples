using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public interface IPizza
    {
        public string GetDescription();
        public float Cost();
    }
}
