using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CalculatorStrategy
{
    public class ContextStrategy
    {
        IStrategy _strategy;

        public ContextStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
