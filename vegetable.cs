using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class vegetable
    {
        public string vegetableKind;
        public int quantity;
        public override string ToString() {
            return  vegetableKind + " " + quantity;
        }
    }
}
