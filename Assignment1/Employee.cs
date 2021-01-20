/* Name: Kevin Kim
 * #: 991456570
 * Date: May 21, 2018
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    // base class
    class Employee
    {
        public string EmployeeId, EmployeeName, EmployeeProfession;

        // Constructor with parameter for Employee
        public Employee(string id, string name, string prof)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.EmployeeProfession = prof;
        }

        // virtual print method
        public virtual string printDetails()
        {
            return String.Format("Employee Details: " +
                this.EmployeeId + " " +
                this.EmployeeName + " " +
                this.EmployeeProfession);
        }
    }
}
