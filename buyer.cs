using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class buyer
    {
        List<vegetable> cart = new List<vegetable>();
        List<transaction> transactionList = new List<transaction>();

        public void sell(ref List<vegetable> shop, ref vegetable toSell)
        {
            if(makeTransaction(ref this.cart, ref shop, toSell)){ transactionList.Add(new transaction("sell", toSell)); }

        }
        public void buy(ref List<vegetable> shop, ref vegetable toBuy)
        {
            if(makeTransaction(ref shop, ref this.cart, toBuy)) { transactionList.Add(new transaction("buy", toBuy)); }
            
        }
        public void order(ref List<vegetable> shop, vegetable toOrder)
        {
            int found = shop.FindIndex(x => x.vegetableKind.Contains(toOrder.vegetableKind));
            if (found != -1) { if (shop[found].quantity < toOrder.quantity) { shop[found].quantity += toOrder.quantity; } } else return;
        }
        private static bool makeTransaction(ref List<vegetable> from, ref List<vegetable> to, vegetable toMove)
        {
            int found = from.FindIndex(x => x.vegetableKind.Contains(toMove.vegetableKind));
            if (found != -1) { if (from[found].quantity >= toMove.quantity) { from[found].quantity -= toMove.quantity; } } else return false;

            int foundTo = to.FindIndex(x => x.vegetableKind.Contains(toMove.vegetableKind));
            if (foundTo != -1) { to[foundTo].quantity += toMove.quantity; }
            else { to.Add(toMove); }
            return true;
         }

        public void printTransactions() {
            Console.WriteLine("There was" + transactionList.Count + " transactions");
            Console.WriteLine("transactions were: ");
            
            
            foreach (transaction t in transactionList)
            {
                                Console.WriteLine(t.transactionType + " " + t.veggie);
            }
        }
    }
}
