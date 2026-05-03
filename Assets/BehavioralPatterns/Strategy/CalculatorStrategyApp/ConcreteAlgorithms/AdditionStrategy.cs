using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CalculatorStrategy
{
    public class AdditionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
