namespace Task1

{
    class Program

    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);


            int number1 = int.Parse(Console.ReadLine());

            if (number1 == randomNumber)
                Console.WriteLine("You win");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 == randomNumber)
                Console.WriteLine("You win");
            int number3 = int.Parse(Console.ReadLine());
            if (number3 == randomNumber)
                Console.WriteLine("You win");
            else Console.WriteLine("You lose");
        }
    }
}


