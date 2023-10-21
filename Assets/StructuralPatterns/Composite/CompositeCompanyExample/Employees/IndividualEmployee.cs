using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Leaf

    public class IndividualEmployee : BaseEmployeeComponent
    {
        public IndividualEmployee(string name, EEmployeePosition postion) : base(name, postion) { }

        public override void ShowInfo(int depth)
        {
            Debug.Log("Depth: " + depth +
                " - Name: " + _name +
                " - Position: " + _position.ToString());
        }
    }
}
