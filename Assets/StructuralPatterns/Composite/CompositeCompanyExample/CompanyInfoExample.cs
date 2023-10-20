using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePersonalExample
{
    public class CompanyInfoExample : MonoBehaviour
    {
        private void Start()
        {
            Manager cEO = new Manager("Ali", EEmployeePosition.CEO);

            Manager cFO = new Manager("Ayşe", EEmployeePosition.CFO);
            Manager salesDirector = new Manager("Mehmet", EEmployeePosition.SalesDirector);

            BaseEmployee accountant = new IndividualEmployee("Zeynep", EEmployeePosition.Accountant);
            BaseEmployee salesperson = new PerformanceAppraisal(new IndividualEmployee("Deniz", EEmployeePosition.SalesPerson), 5);

            cEO.AddSubordinate(cFO);
            cEO.AddSubordinate(salesDirector);
            cFO.AddSubordinate(accountant);
            salesDirector.AddSubordinate(salesperson);
            

            Debug.Log("Organizational Structure:");
            salesDirector.ShowInfo(0);
        }
    }
}
