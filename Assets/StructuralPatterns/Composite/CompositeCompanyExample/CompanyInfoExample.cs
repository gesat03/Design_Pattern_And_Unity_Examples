using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    public class CompanyInfoExample : MonoBehaviour
    {
        private void Start()
        {
            //Composite
            Manager cEO = new Manager("Ali", EEmployeePosition.CEO);
            //Composite
            Manager cFO = new Manager("Ayşe", EEmployeePosition.CFO);
            Manager salesDirector = new Manager("Mehmet", EEmployeePosition.SalesDirector);
            // Leaf
            BaseEmployeeComponent accountant = new IndividualEmployee("Zeynep", EEmployeePosition.Accountant);
            // Extended with Decorator
            BaseEmployeeComponent salesperson = new PerformanceAppraisal(new IndividualEmployee("Deniz", EEmployeePosition.SalesPerson), 5);

            cEO.AddSubordinate(cFO);
            cEO.AddSubordinate(salesDirector);
            cFO.AddSubordinate(accountant);
            salesDirector.AddSubordinate(salesperson);
            

            Debug.Log("Organizational Structure:");
            salesDirector.ShowInfo(0);
        }
    }
}
