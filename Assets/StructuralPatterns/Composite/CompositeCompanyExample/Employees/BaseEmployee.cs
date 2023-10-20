using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Component

    public abstract class BaseEmployee
    {

        public string _name;
        public EEmployeePosition _position;
        
        public BaseEmployee(string name, EEmployeePosition employee)
        {
            _name = name;
            _position = employee;
        }

        public abstract void ShowInfo(int depth);
    }
}
