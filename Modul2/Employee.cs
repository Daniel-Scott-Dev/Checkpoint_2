namespace Modul2
{
    public class Employee : Person
    {
        public DateOnly HireDate { get; protected set; }

        public Employee(string name, int age, DateOnly hireDate) : base(name, age)
        {
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return base.ToString() + $"Hire date: {HireDate}\n";
        }


    }
}
