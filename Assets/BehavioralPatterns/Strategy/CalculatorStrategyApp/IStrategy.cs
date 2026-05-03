using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CalculatorStrategy
{
    public interface IStrategy
    {
        public int Execute(int a, int b);
    }
}
