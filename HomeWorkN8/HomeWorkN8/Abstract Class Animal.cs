using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN8
{
    public interface IAnimal
    {
        string MakeSound();
    }
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

 
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string MakeSound();
    }
}
