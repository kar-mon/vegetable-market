using System;
using System.Collections.Generic;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<vegetable> shop = new List<vegetable>();

            shop.Add(new vegetable() { vegetableKind = "onion",  quantity = 5}) ;
            shop.Add(new vegetable() { vegetableKind = "tomato", quantity = 5});
            shop.Add(new vegetable() { vegetableKind = "potato",  quantity = 5 });

            Console.WriteLine("There are " + shop[0].quantity + " onions in stock.");
            Console.WriteLine("There are " + shop[1].quantity + " tomatoes in stock.");
            Console.WriteLine("There are " + shop[2].quantity + " potatoes in stock.");
            
            Console.WriteLine("buying vegetables");

            buyer buyer = new buyer();
            vegetable vegetableToBuy = new vegetable() {vegetableKind="onion",quantity=5 };
            buyer.buy(ref shop, ref vegetableToBuy);
            vegetable vegetableToBuy2 = new vegetable() { vegetableKind = "tomato", quantity = 2 };
            buyer.buy(ref shop, ref vegetableToBuy2);
            vegetable vegetableToBuy3 = new vegetable() { vegetableKind = "potato", quantity = 4 };
            buyer.buy(ref shop, ref vegetableToBuy3);

            Console.WriteLine("There are " + shop[0].quantity + " onions in stock.");
            Console.WriteLine("There are " + shop[1].quantity + " tomatoes in stock.");
            Console.WriteLine("There are " + shop[2].quantity + " potatoes in stock.");

            Console.WriteLine("selling vegetables");

            vegetable toSell = new vegetable() { vegetableKind = "potato", quantity = 2 };
            buyer.sell(ref shop, ref toSell);
            vegetable toSell2 = new vegetable() { vegetableKind = "tomato", quantity = 2 };
            buyer.sell(ref shop, ref toSell2);

            Console.WriteLine("There are " + shop[0].quantity + " onions in stock.");
            Console.WriteLine("There are " + shop[1].quantity + " tomatoes in stock.");
            Console.WriteLine("There are " + shop[2].quantity + " potatoes in stock.");

            Console.WriteLine("ordering vegetables");
            vegetable toOrder = new vegetable() { vegetableKind = "onion", quantity = 5 };
            buyer.order(ref shop, toOrder);

            Console.WriteLine("There are " + shop[0].quantity + " onions in stock.");
            Console.WriteLine("There are " + shop[1].quantity + " tomatoes in stock.");
            Console.WriteLine("There are " + shop[2].quantity + " potatoes in stock.");

            
            buyer.printTransactions();

        }
    }
}