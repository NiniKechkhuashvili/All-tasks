namespace HomeWorkN10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part 1
            Counter counter1 = new Counter();
            Console.WriteLine($"Number of count: {Counter.GetCount()}");

            Counter counter2 = new Counter();
            Console.WriteLine($"Number of count: {Counter.GetCount()}");

            Counter counter3 = new Counter();
            Console.WriteLine($"Number of count: {Counter.GetCount()}");

            Counter.ResetCount();
            Console.WriteLine($"Number of count after ResetCount(): {Counter.GetCount()}");

            Counter counter4 = new Counter();
            Console.WriteLine($"Number of count: {Counter.GetCount()}");

            //Part 2

            int n1 = 12;
            int n2 = 4;

            int sum = MathHelper.Add(n1, n2);
            Console.WriteLine($"Addition: {n1} + {n2} = {sum}");

            int difference = MathHelper.Subtract(n1, n2);
            Console.WriteLine($"Subtraction: {n1} - {n2} = {difference}");

            int multiply = MathHelper.Multiply(n1, n2);
            Console.WriteLine($"Multiplication: {n1} * {n2} = {multiply}");

            double division = MathHelper.Divide(n1, n2);
            Console.WriteLine($"Division: {n1} / {n2} = {division}");


        }
    }
}
