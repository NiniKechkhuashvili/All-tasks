namespace HomeWorkN7
{
    public class Person
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string personName = "Nini";
            int personAge = 25;

            Person person1 = new Person();
            person1.Name = personName;
            person1.Age = personAge;

            Person person2 = person1;

            person2.Name = "Nana";
            person2.Age = 35;

            Console.WriteLine($"person1 - Name: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"person2 - Name: {person2.Name}, Age: {person2.Age}");
        }
    }

}