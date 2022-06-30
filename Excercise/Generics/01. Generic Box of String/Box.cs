using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
   public class Box<T>
    {
        private T name;

        public T Name
        {
            get { return name; }
            set { name = value; }
        }
        public Box(T name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {Name}";
        }
    }
}
