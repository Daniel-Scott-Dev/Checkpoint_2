namespace Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new("Scott's CarWash");

            //company.DatabaseList = new(); Initiert denne i propertien i steden.
            //tok vekk assigning av verdier i employee class. holder med : base...

            Employee employee1 = new("Daniel", 34, new DateOnly(2019, 01, 12));
            company.DatabaseList.Add(employee1);

            Employee employee2 = new("Silje", 32, new DateOnly(2020, 01, 12));
            company.DatabaseList.Add(employee2);

            Employee employee3 = new("Iben", 2, new DateOnly(2022, 01, 12));
            company.DatabaseList.Add(employee3);

            company.PrintAllEmployees();

            Console.WriteLine($"{company.Name} has {company.DatabaseList.Count} employee's");





        }
    }
}