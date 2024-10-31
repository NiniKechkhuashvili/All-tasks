namespace HomeWorkN5
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine("write a whole number");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, int.Parse);


            Console.WriteLine("write an index");
            int index = int.Parse(Console.ReadLine());


            int result = Sum(array, index);
            Console.WriteLine($"sum of numbers for index {index}: {result}");
        }

        static int Sum(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Index");
                return 0;
            }

            int number = array[index];
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }


}
