using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    // Composite

    public class Manager : BaseEmployee
    {
        private List<BaseEmployee> subordinates;

        public Manager(string name, EEmployeePosition position) : base(name, position) 
        {
            subordinates = new List<BaseEmployee>();
        }

        public void AddSubordinate(BaseEmployee employee)
        {
            subordinates.Add(employee);
        }

        public void RemoveSubordinate(BaseEmployee employee)
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
