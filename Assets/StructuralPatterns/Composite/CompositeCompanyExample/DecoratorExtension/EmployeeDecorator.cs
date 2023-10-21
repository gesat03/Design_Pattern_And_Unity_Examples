using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Decorator

    public abstract class EmployeeDecorator : BaseEmployeeComponent
    {
        protected BaseEmployeeComponent _employee;

        public EmployeeDecorator(BaseEmployeeComponent employee) : base(employee._name, employee._position)
        {
            _employee = employee;
        }

        public override void ShowInfo(int depth)
        {
            _employee.ShowInfo(depth);
        }
    }
}
