using System;
using System.Collections.Generic;
using System.Linq;
using MainBakery;

namespace Items
{
    public static class MenuItems{
        public class Bread
        {
            public string name { get; set; }
            public int price { get; set; }
            public int discountRate { get; set; }
            public int quantity { get; set; }    
            public static int Deal(int qty)
            {
                double calc = qty/3;
                int dealCalc = (int)calc;
                int discount = dealCalc*5;
                Console.WriteLine($"Total {qty}, amount of thirds {dealCalc}, and total discount: ${discount}.");
                return Shop.totalDiscounts = discount;
            }

        }

        public class Pastry
        {
            public string name { get; set; }
            public int price { get; set; }
            public int discountRate { get; set; }
            public int quantity { get; set; }           
            public static int Deal(int qty)
            {
                double calc = qty/3;
                int dealCalc = (int)calc;
                int discount = dealCalc*1;
                Console.WriteLine($"Total {qty}, amount of thirds {dealCalc}, and total discount: ${discount}.");
                return Shop.totalDiscounts = discount;
            }

        }

    }
}
