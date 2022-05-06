using System;
using System.Collections.Generic;
using System.Linq;
using Items;

namespace MainBakery
{
    public class Shop
    {
        public static void Main()
        {
            //Menu offering as if a real shop, used get/set because irl prices can change by the hour:
            Bread loaf = new Bread();
            loaf.name = "Rye";
            loaf.price = 5;
            Pastry croissant = new Pastry();
            croissant.name = "Almond Croissant";
            croissant.price = 5;
            //Welcome!
            Shop.Welcome(loaf, croissant);

        }

        //Method is intended to pass two seperate objects, therefore "object" is declared since it is two seperate classes.
        // public static int DealOffer(object item)
        // {
        //     if (item == loaf)
        //     {

        //     } else if (item == pastry)
        //     {

        //     }
        // }

        private static void Welcome(Bread menu1, Pastry menu2)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*******************    MENU DU JOUR    ***********************");
            Console.WriteLine("Hi and welcome to Pierre's Patisserie *French accent oh la la*");
            Console.WriteLine("**************************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Here's what we have to offer: ");
            Console.WriteLine($"1. {menu1.name} loaves");
            Console.WriteLine($"2. {menu2.name}s ");
            Console.WriteLine(" ");
        }
    }
}
