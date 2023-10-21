using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Composite

    public class Manager : BaseEmployeeComponent
    {
        private List<BaseEmployeeComponent> subordinates;

        public Manager(string name, EEmployeePosition position) : base(name, position) 
        {
            subordinates = new List<BaseEmployeeComponent>();
        }

        public void AddSubordinate(BaseEmployeeComponent employee)
        {
            subordinates.Add(employee);
        }

        public void RemoveSubordinate(BaseEmployeeComponent employee)
        {
            subordinates.Remove(employee);
        }

        public override void ShowInfo(int depth)
        {
            Debug.Log("Depth: " + depth +
                " - Name: " + _name +
                " - Position: " + _position.ToString());

            foreach (var sub in subordinates)
            {
                sub.ShowInfo(depth + 2);
            }
        }
    }
}
