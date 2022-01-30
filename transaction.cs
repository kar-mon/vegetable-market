using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class transaction
    {
        public string transactionType;
        public vegetable veggie;

        public transaction(string transactionType, vegetable veggie) {
            this.transactionType = transactionType;
            this.veggie = veggie;
        }
    }





}
