namespace Task1

{
    class Program

    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);


            int number = int.Parse(Console.ReadLine());

            if (number == randomNumber)
                Console.WriteLine("You win");
            else
{                number = int.Parse(Console.ReadLine());
                if (number == randomNumber)
                Console.WriteLine("You win");
                else
{                    number = int.Parse(Console.ReadLine());
                    if (number == randomNumber)
                        Console.WriteLine("You win");
                    else 
                        Console.WriteLine("You lose");
                }
            }
        }
    }
}


