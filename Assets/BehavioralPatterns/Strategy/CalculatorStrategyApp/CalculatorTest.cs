using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CalculatorStrategy
{
    public class CalculatorTest : MonoBehaviour
    {
        public int A, B;

        IStrategy _additionStrategy;
        IStrategy _substractStrategy;
        IStrategy _multiplyStrategy;

        ContextStrategy _context;


        void Start()
        {
            _additionStrategy = new AdditionStrategy();
            _substractStrategy = new SubtructionStrategy();
            _multiplyStrategy = new MultiplyStrategy();

            _context = new ContextStrategy(_additionStrategy);
            Debug.Log(_context.ExecuteStrategy(A, B));

            _context = new ContextStrategy(_substractStrategy);
            Debug.Log(_context.ExecuteStrategy(A, B));

            _context = new ContextStrategy(_multiplyStrategy);
            Debug.Log(_context.ExecuteStrategy(A, B));
        }

        
    }
}
