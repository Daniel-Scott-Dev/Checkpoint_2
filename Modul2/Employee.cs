using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    public class Employee : Person
    {
        public DateTime HireDate { get; set; }

        public Employee(string name, int age, DateTime hireDate) : base(name, age)
        {
            Name = name;
            Age = age;
            HireDate = hireDate;
        }

        
    }
}
