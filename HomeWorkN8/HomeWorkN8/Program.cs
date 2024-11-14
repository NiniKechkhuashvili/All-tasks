namespace HomeWorkN8
{
    class Program
    {
        static void Main()
        {
            IAnimal[] animals = new IAnimal[]
            {
            new Dog("Rex", 3),
            new Cat("Whiskers", 2),
            new Cow("Bessie", 5)
            };


            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }

        }
    }
}
