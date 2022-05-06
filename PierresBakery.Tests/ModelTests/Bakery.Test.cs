using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Items;
using MainBakery;


namespace Bakery.Tests
{
  [TestClass]
  public class ShopTests
  {

    [TestMethod]
    public void Welcome_TakesObjectsAsArguementsAndDisplaysTheirProperties_StringAndInt()
    {
      MenuItems.Bread loaf = new MenuItems.Bread();
      loaf.name = "Rye";
      loaf.price = 5;
      Console.WriteLine($"1. {loaf.name} loaves at ${loaf.price} per loaf.");
      Assert.AreEqual(loaf.name, "Rye");
      Assert.AreEqual(loaf.price, 5);
    }

    [TestMethod]
    public void Buy_TakesInputAndChecksIfItemExistsAsKeyInFullMenuThenProceeds_StringAndInt()
    {
        Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        MenuItems.Bread loaf = new MenuItems.Bread();
        loaf.name = "Rye";
        loaf.price = 5;
        fullMenu.Add(loaf.name, loaf.price);
        //user input fields, change value of inputName to red, green check.
        string inputName = "Rye";
        if (!fullMenu.ContainsKey(inputName))
        {
          Console.WriteLine("Please enter a proper menu item, this item does not exist!");
        }
        Assert.AreEqual(fullMenu.ContainsKey(inputName), true);
    }

    [TestMethod]
    public void calcTotalCost_TakesInputAndSearchesFullMenuDictionaryKeysViaStringThenTakesValueAndMultipliesItByQty_Int()
    {      
        Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        MenuItems.Bread loaf = new MenuItems.Bread();
        loaf.name = "Rye";
        loaf.price = 5;
        fullMenu.Add(loaf.name, loaf.price);
        //user input fields, change value of inputName to red, green check.
        //User buys "Rye" bread at a quantity of 6 units total, $5 price each.
        string inputName = "Rye";
        int qty = 6;
        int result = fullMenu[inputName]*qty;
        Assert.AreEqual(result, 30);
    }

    [TestMethod]
    public void BreadDotDeal_CalculatesNumberOfLoavesByThirdsRoundedDownReturnsDiscountedQuantity_Int()
    {
        Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        MenuItems.Bread loaf = new MenuItems.Bread();
        loaf.name = "Rye";
        loaf.price = 5;
        fullMenu.Add(loaf.name, loaf.price);
        //user input fields, change value of inputName to red, green check.
        //User buys "Rye" bread at a quantity of 6 units total, $5 price each.
        string inputName = "Rye";
        int qty = 6;
        int result = fullMenu[inputName]*qty;
        double calc = qty/3;
        int dealCalc = (int)calc;
        int discount = dealCalc*5;
        Console.WriteLine($"Total {qty}, amount of thirds {dealCalc}, and total discount: ${discount}.");
        Shop.totalDiscounts = discount;
        Assert.AreEqual(Shop.totalDiscounts, 10);
    }

    [TestMethod]
    public void PastryDotDeal_CalculatesNumberOfPastriesByThreesRoundedDownForDiscountCalc_Int()
    {
        Dictionary<string, int> fullMenu = new Dictionary<string, int>();
        MenuItems.Pastry danish = new MenuItems.Pastry();
        danish.name = "Danish";
        danish.price = 2;
        fullMenu.Add(danish.name, danish.price);
        int qty = 6;
        //set Shop.totalCost WITHOUT discount.
        Shop.totalCost = (danish.price*qty);
        //calculate discount.
        double calc = qty/3;
        int dealCalc = (int)calc;
        int discount = dealCalc*1;
        Console.WriteLine($"Total {qty}, amount of thirds {dealCalc}, and total discount: ${discount}.");
        Shop.totalDiscounts = discount;
        Shop.totalCost -= Shop.totalDiscounts;
        Assert.AreEqual(Shop.totalDiscounts, 2);
        Assert.AreEqual(Shop.totalCost, 10);
    }
  }
}