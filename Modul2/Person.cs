namespace Modul2
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\n";
        }

    }
}
