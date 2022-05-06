using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      Console.WriteLine($"1. {loaf.name} loaves");
      Assert.AreEqual(loaf.name, "Rye");
    }
  }
}