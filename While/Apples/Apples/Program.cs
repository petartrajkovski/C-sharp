using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    class Program
    {
        static void Main(string[] args)
        {
            apples();
        }

        static void apples()
        {
            double apples;
            double applesInBasket;
            double baskets;
            double emptySpaces;

            Console.WriteLine("Enter number of apples:");
            apples = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of applesInBasket:");
            applesInBasket = Convert.ToInt32(Console.ReadLine());

            baskets = Math.Ceiling(apples / applesInBasket);
            Console.WriteLine("You need " + baskets + " baskets to collect all the apples from the tree");

            emptySpaces = (applesInBasket * baskets - apples);
            Console.WriteLine("You have space for " + emptySpaces + " more apples in your baskets");
            Console.ReadLine();
        }
    }
}
