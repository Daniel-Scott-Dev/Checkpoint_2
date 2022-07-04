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
            Company expected = new(expectedName,expectedEmployeeCount);

            //actual
            Company actual = new(expectedName, expectedEmployeeCount);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestEmployee()
        {
            //expected
            string name = "Jakob";
            int age = 43;
            string hireDate = "22.02.2020";
            Employee expected = new(name, age, hireDate);

            //actual
            Employee actual = new(name, age, hireDate);

            //compare
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Person()
        {
            Assert.Pass();
        }
    }
}