using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN8
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Woof";
        }
    }
}
