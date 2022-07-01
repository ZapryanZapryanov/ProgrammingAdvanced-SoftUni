using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Threeuple
{
    class Tuple<TFirst, TSecond, TThree>
    {
        public TFirst Type1 { get; set; }
        public TSecond Type2 { get; set; }
        public TThree Type3 { get; set; }
        public Tuple(TFirst item1, TSecond item2, TThree type3)
        {
            this.Type1 = item1;
            this.Type2 = item2;
            this.Type3 = type3;
        }
        public override string ToString()
        {
            return $"{Type1} -> {Type2} -> {Type3}";
        }
    }
}
