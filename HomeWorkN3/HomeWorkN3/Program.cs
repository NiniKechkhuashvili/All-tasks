using System.Collections;
 
namespace Lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("pasuxi:");
 
            switch (number)
            {
                case 0:
                    Console.WriteLine("kvira");
                    break;
                case 1:
                    Console.WriteLine("orshabati");
                    break;
                case 2:
                    Console.WriteLine("samshabati");
                    break;
                case 3:
                    Console.WriteLine("otxshabati");
                    break;
                case 4:
                    Console.WriteLine("xutshabati");
                    break;
                case 5:
                    Console.WriteLine("paraskevi");
                    break;
                case 6:
                    Console.WriteLine("shabati");
                    break;
                default:
                    Console.WriteLine("incorrect value");
                    break;
            }
        }
    }
 
}
