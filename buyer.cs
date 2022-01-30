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

        public void sell(ref List<vegetable> shop, ref vegetable toSell)
        {
            makeTransaction(ref this.cart, ref shop, toSell);
        }
        public void buy(ref List<vegetable> shop, ref vegetable toBuy)
        {
            makeTransaction(ref shop, ref this.cart, toBuy);
        }
        public void order(ref List<vegetable> shop, vegetable toOrder)
        {
            int found = shop.FindIndex(x => x.vegetableKind.Contains(toOrder.vegetableKind));
            if (found != -1) { if (shop[found].quantity < toOrder.quantity) { shop[found].quantity += toOrder.quantity; } } else return;
        }
        private static void makeTransaction(ref List<vegetable> from, ref List<vegetable> to, vegetable toMove)
        {
            int found = from.FindIndex(x => x.vegetableKind.Contains(toMove.vegetableKind));
            if (found != -1) { if (from[found].quantity >= toMove.quantity) { from[found].quantity -= toMove.quantity; } } else return;

            int foundTo = to.FindIndex(x => x.vegetableKind.Contains(toMove.vegetableKind));
            if (foundTo != -1) { to[foundTo].quantity += toMove.quantity; }
            else { to.Add(toMove); }


        }
    }
}
