using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN8
{
    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Moo";
        }
    }
}
