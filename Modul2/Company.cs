namespace Modul2
{
    public class Company
    {
        public string Name { get; protected set; }
        public int EmployeeCount { get; protected set; }
        public List<Person> DatabaseList { get; set; } = new();


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

        //public override bool Equals(object obj)
        //{
        //    if (obj is Employee)
        //    {
        //        // Compare using our normal Equals method:
        //        return Equals((Employee)obj);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
