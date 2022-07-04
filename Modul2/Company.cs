using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    public class Company
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public List<Person> DatabaseList { get; set; }

        
        public Company(string name, int employeeCount = 0)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }

        public void PrintAllEmployees()
        {
            foreach (var employee in DatabaseList)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
