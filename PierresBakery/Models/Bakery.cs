using System;
using System.Collections.Generic;
using System.Linq;
using Items;

namespace MainBakery
{
    public class Shop
    {
        private static Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        public static int totalCost = 0;
        public static int totalDiscounts = 0;
        public static void Main()
        {
            //Menu offering as if a real shop, used get/set because irl prices can change by the hour:
            MenuItems.Bread rye = new MenuItems.Bread();
            rye.name = "Rye";
            rye.price = 5;
            rye.discountRate = 5;
            fullMenu.Add(rye.name, rye.price);
            MenuItems.Pastry croissant = new MenuItems.Pastry();
            croissant.name = "Croissant";
            croissant.price = 2;
            croissant.discountRate = 1;
            fullMenu.Add(croissant.name, croissant.price);
            //Welcome!
            Shop.Welcome(rye, croissant);
            Shop.Buy();
        }
        private static void Welcome(MenuItems.Bread menu1, MenuItems.Pastry menu2)
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
            char[] letters = inputName.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            inputName = new string(letters);
            Console.WriteLine($"You entered: {inputName}");
            if (fullMenu.Keys.Contains(inputName))
            {
                //Needing to handle string input for quantity bug.
                Console.WriteLine("Please enter the amount you would like: ");
                int quantity = Int32.Parse(Console.ReadLine());
                if (quantity.GetType() == typeof(int))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine(" ");
                    Console.WriteLine($"You've entered {inputName} at {quantity} units total.");
                    int aggregateCost = calcTotalCost(inputName, quantity);
                    Console.WriteLine($"Previous Shopping Cart Total: ${Shop.totalCost}");
                    Shop.totalCost += aggregateCost;
                    Shop.totalCost -= Shop.totalDiscounts;
                    Console.WriteLine($"Your Current Shopping Cart Total is: ${Shop.totalCost}");
                    Console.WriteLine(" ");
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine(" ");
                    Buy();
                } else if (quantity.GetType() != typeof(int))
                {
                    Console.WriteLine("Please enter a number only! Thank you.");
                }
            } else {
                Console.WriteLine("Please enter a proper menu item, this item does not exist!");
                Buy();
                return;
            }
        }

        private static int calcTotalCost(string itemName, int qty)
        {
            int result = fullMenu[itemName]*qty;
            if (itemName == "Rye")
            {
                MenuItems.Bread.Deal(qty);
            }
            else if (itemName == "Croissant")
            {
                MenuItems.Pastry.Deal(qty);
            }
            return result;
        }

    }
}
