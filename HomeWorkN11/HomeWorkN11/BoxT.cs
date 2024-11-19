using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN11
{
    internal class Box<T>;

public class Box<T>
    {
        private T value;

        public void SetValue(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return this.value;
        }
    }
}
}
