using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Component

    public abstract class BaseEmployeeComponent
    {

        public string _name;
        public EEmployeePosition _position;
        
        public BaseEmployeeComponent(string name, EEmployeePosition employee)
        {
            _name = name;
            _position = employee;
        }

        public abstract void ShowInfo(int depth);
    }
}
