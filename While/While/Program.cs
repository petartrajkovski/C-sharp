using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintNumbersAscending();
            //PrintNumbersDescending();
            //PrintEvenNumbers();
            //PrintOddNumbers();
            BreakForLoop();
        }

        //static void PrintNumbersAscending()
        //{
        //    int Number;
        //    int x = 1;

        //    Console.WriteLine("Enter number:");
        //    Number = Convert.ToInt32(Console.ReadLine());

        //    while (x < Number) 
        //    {
        //        Console.WriteLine(x);
        //        x++; 
        //    }
        //    Console.ReadLine();
        //}

        //static void PrintNumbersDescending()
        //{
        //    int Number;

        //    Console.WriteLine("Enter number:");
        //    Number = Convert.ToInt32(Console.ReadLine());

        //    while (Number >= 1)
        //    {
        //        Console.WriteLine(Number);
        //        Number--;
        //    }
        //    Console.ReadLine();
        //}

        //static void PrintEvenNumbers()
        //{
        //    int Number;
        //    int x = 2;

        //    Console.WriteLine("Enter number:");
        //    Number = Convert.ToInt32(Console.ReadLine());

        //    while (x <= Number)
        //    {
        //        Console.WriteLine(x);
        //        x += 2;
        //    }
        //    Console.ReadLine();
        //}

        //static void PrintOddNumbers()
        //{
        //    int Number;
        //    int x = 1;

        //    Console.WriteLine("Enter number:");
        //    Number = Convert.ToInt32(Console.ReadLine());

        //    while (x <= Number)
        //    {
        //        Console.WriteLine(x);
        //        x += 2;
        //    }
        //    Console.ReadLine();
        //}

        static void BreakForLoop()
        {
            int Number = 1;
            int x = 10;

            while (Number <= x)
            {
                if (Number == 7)
                {
                    break;
                }
                Console.WriteLine(Number);
                Number ++;
            }
            Console.ReadLine();
        }
    }
}


//double apples;
//double applesInBasket;
//double baskets;
//double emptySpaces;

//Console.WriteLine("Enter number of apples:");
//            apples = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter number of applesInBasket:");
//            applesInBasket = Convert.ToInt32(Console.ReadLine());

//            baskets = Math.Ceiling(apples / applesInBasket);
//            Console.WriteLine("You need " + baskets + " baskets to collect all the apples from the tree");

//            emptySpaces = (applesInBasket* baskets - apples);
//            Console.WriteLine("You have space for " + emptySpaces + " more apples in your baskets");
//            Console.ReadLine();
