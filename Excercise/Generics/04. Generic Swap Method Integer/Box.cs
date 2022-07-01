using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Generic_Swap_Method_Integer
{
   public class Box<T>
    {
        private List<T> name;

        public List<T> Name
        {
            get { return name; }
            set { name = value; }
        }
        public Box()
        {
            this.Name = new List<T>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Name)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
        public void SwapElements(int firstIndex, int secondIndex)
        {
            T firstElement = Name[firstIndex];
            T secondElement = Name[secondIndex];
            Name[secondIndex] = firstElement;
            Name[firstIndex] = secondElement;
            


        }
    }
}
