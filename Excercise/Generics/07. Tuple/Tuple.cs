using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Tuple
{
    class Tuple<TFirst, TSecond>
    {
        public TFirst Type1 { get; set; }
        public TSecond Type2 { get; set; }
        public Tuple(TFirst item1, TSecond item2)
        {
            this.Type1 = item1;
            this.Type2 = item2;
        }
        public override string ToString()
        {
            return $"{Type1} -> {Type2}";
        }
    }
}
