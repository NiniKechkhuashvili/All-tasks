using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number");
            int sum = 0;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Continue");

                if (a < 0)

                {
                    break;


                }

                sum += a;
            }

            Console.WriteLine("You Lose, sum : " + sum);
        }
    }
}

