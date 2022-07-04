using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    public class Employee : Person
    {
        public string HireDate { get; set; }

        public Employee(string name, int age, string hireDate) : base(name, age)
        {
            Name = name;
            Age = age;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return base.ToString() + $"Hire date: {HireDate}\n";
        }

        
    }
}
