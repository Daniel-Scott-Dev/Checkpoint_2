namespace Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new("Scott's CarWash");

            company.DatabaseList = new();

            Employee employee1 = new("Daniel", 34, "20.01.2020");
            company.DatabaseList.Add(employee1);

            Employee employee2 = new("Silje", 32, "21.01.2020");
            company.DatabaseList.Add(employee2);

            Employee employee3 = new("Iben", 2, "04.05.2022");
            company.DatabaseList.Add(employee3);

            company.PrintAllEmployees();

            Console.WriteLine($"{company.Name} has {company.DatabaseList.Count} employee's");




        }
    }
}