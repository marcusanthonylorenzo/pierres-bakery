using System;
using System.Collections.Generic;
using System.Linq;
using Items;

namespace MainBakery
{
    public class Shop
    {
        public static Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        public static void Main()
        {
            //Menu offering as if a real shop, used get/set because irl prices can change by the hour:
            Bread rye = new Bread();
            rye.name = "Rye";
            rye.price = 5;
            fullMenu.Add(rye.name, rye.price);
            Pastry croissant = new Pastry();
            croissant.name = "Almond Croissant";
            croissant.price = 5;
            fullMenu.Add(croissant.name, croissant.price);

            //Welcome!
            Console.WriteLine(fullMenu.Keys);
            Shop.Welcome(rye, croissant);
            Shop.Buy();

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
            Console.WriteLine($"1. {menu1.name} loaves at ${menu1.price} per loaf.");
            Console.WriteLine($"2. {menu2.name}s at ${menu2.price} per pastry.");
            Console.WriteLine(" ");
        }
        
        public static void Buy()
        {
            Console.WriteLine("Please enter the name of the item you would like:");
            string inputName = Console.ReadLine();
            if (!fullMenu.ContainsKey(inputName))
            {
                Console.WriteLine("Please enter a proper menu item, this item does not exist!");
                Buy();
            }
            Console.WriteLine("Please enter the amount you would like: ");
            int quantity = Int32.Parse(Console.ReadLine());
 
            Console.WriteLine($"You've entered {inputName} at {quantity} units total.");
        }
    }
}
