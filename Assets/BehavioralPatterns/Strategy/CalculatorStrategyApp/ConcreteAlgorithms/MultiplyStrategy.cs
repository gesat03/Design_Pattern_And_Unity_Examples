using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CalculatorStrategy
{
    public class MultiplyStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
