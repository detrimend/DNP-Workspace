namespace ConsoleApplication
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}");
        }
    }
}