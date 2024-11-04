namespace HomeWorkN5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];

            Console.WriteLine($"Enter {elements} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the index to sum digits of that element:");
            int index = int.Parse(Console.ReadLine());

            int result = SumOfNumbers(array, index);
            Console.WriteLine($"Sum of digits: {result}");
        }

        static int SumOfNumbers(int[] array, int index)
        {
            int number = 0;
            string mystr = array[index].ToString();

            foreach (char i in mystr)
            {
                number += int.Parse(i.ToString());
            }

            return number;
        }
    }
}
