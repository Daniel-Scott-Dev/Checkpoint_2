using Modul2;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCompany()
        {
            //Expected
            string expectedName = "AW";
            int expectedEmployeeCount = 3;
            Company expected = new(expectedName, expectedEmployeeCount);

            //actual
            Company actual = new(expectedName, expectedEmployeeCount);

            //Compare
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
            Assert.That(actual.EmployeeCount, Is.EqualTo(expected.EmployeeCount));
        }

        [Test]
        public void TestEmployee()
        {
            //expected
            string name = "Jakob";
            int age = 43;
            DateOnly hireDate = new(2020, 02, 12);

            Employee expected = new(name, age, hireDate);

            //actual
            Employee actual = new(name, age, hireDate);

            //compare
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
            Assert.That(actual.Age, Is.EqualTo(expected.Age));
            Assert.That(actual.HireDate, Is.EqualTo(expected.HireDate));
        }

        [Test]
        public void EmployeeToStringMethod()
        {
            //expected
            string name = "Sondre";
            int age = 22;
            DateOnly hireDate = new(2020, 02, 12);
            
            Employee employee = new(name, age, hireDate);
            string expected = employee.ToString();

            //actual
            string actual = $"Name: {name}\nAge: {age}\nHire date: {hireDate}\n";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}