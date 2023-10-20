using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    public class PerformanceAppraisal : EmployeeDecorator
    {

        int _point;

        public PerformanceAppraisal(BaseEmployee employee, int point) : base(employee)
        {
            _point = point;
        }

        public override void ShowInfo(int depth)
        {
            base.ShowInfo(depth);

            AdditionalInfo();
        }

        void AdditionalInfo()
        {
            Debug.Log("This Employee also has " + _point +" point.");
        }

    }
}
