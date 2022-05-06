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
      Bread loaf = new Bread();
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
      Bread loaf = new Bread();
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
      Bread loaf = new Bread();
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
  }
}