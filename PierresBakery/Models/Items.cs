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
            public int quantity { get; set; }    
            public static int Deal(int qtyBread)
            {
                double calcBread = qtyBread/3;
                int dealCalcBread = (int)calcBread;
                int discountBread = dealCalcBread*5;
                Console.WriteLine($"Total units ordered: {qtyBread}, amount of thirds {dealCalcBread}, and total discount: ${discountBread}.");
                return Shop.totalDiscounts = discountBread;
            }
        }

        public class Pastry
        {
            public string name { get; set; }
            public int price { get; set; }
            public int quantity { get; set; }           
            public static int Deal(int qtyPastry)
            {
                double calcPastry = qtyPastry/3;
                int dealCalcPastry = (int)calcPastry;
                int discountPastry = dealCalcPastry*1;
                Console.WriteLine($"Total units ordered: {qtyPastry}, amount of thirds {dealCalcPastry}, and total discount: ${discountPastry}.");
                return Shop.totalDiscounts = discountPastry;
            }

        }

    }
}
