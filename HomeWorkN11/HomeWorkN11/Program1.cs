using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN11
{
    class Program1
    {
        static void Main()
        {
            Box<int> intBox = new Box<int>();
            intBox.SetValue(42);
            Console.WriteLine($"Box<int> value: {intBox.GetValue()}");

            Box<string> stringBox = new Box<string>();
            stringBox.SetValue("Hello, world!");
            Console.WriteLine($"Box<string> value: {stringBox.GetValue()}");

            Box<double> doubleBox = new Box<double>();
            doubleBox.SetValue(3.14);
            Console.WriteLine($"Box<double> value: {doubleBox.GetValue()}");

            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            int countInt = Utility.GetCount(intList);
            Console.WriteLine($"Number of elements in List<int>: {countInt}");

            List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };
            int countString = Utility.GetCount(stringList);
            Console.WriteLine($"Number of elements in List<string>: {countString}");
        }
    }
}
