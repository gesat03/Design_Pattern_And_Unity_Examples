using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Decorator

    public abstract class EmployeeDecorator : BaseEmployee
    {
        protected BaseEmployee _employee;

        public EmployeeDecorator(BaseEmployee employee) : base(employee._name, employee._position)
        {
            _employee = employee;
        }

        public override void ShowInfo(int depth)
        {
            _employee.ShowInfo(depth);
        }
    }
}
