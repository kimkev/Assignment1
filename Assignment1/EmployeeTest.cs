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
    // test class
    class EmployeeTest
    {
        static void Main(String[] args)
        {
            // instantiate list of type SelfEmployee
            List<SelfEmployee> employeeList = new List<SelfEmployee>();

            string id, name, prof, wage, hour, answer;

            // do-while loop to gather user input
            do
            {
                Console.WriteLine("Please enter employee id: ");
                id = Console.ReadLine();
                Console.WriteLine("Please enter employee name: ");
                name = Console.ReadLine();
                Console.WriteLine("Please enter employee profession: ");
                prof = Console.ReadLine();
                Console.WriteLine("Please enter employee hourly wage: ");
                wage = Console.ReadLine();
                Console.WriteLine("Please enter employee total hours: ");
                hour = Console.ReadLine();
                SelfEmployee employee = new SelfEmployee(id, name, prof, Double.Parse(wage), Double.Parse(hour));
                employeeList.Add(employee);
                Console.WriteLine("Do you wish to add more employee details?(Y/N): ");
                answer = Console.ReadLine();
            }
            while (answer == "Y" || answer == "y");


            // for each loop to print out employees
            foreach (var value in employeeList) { 
                Console.WriteLine(value.printDetails());
            }
            Console.ReadKey();
        }
    }
}
