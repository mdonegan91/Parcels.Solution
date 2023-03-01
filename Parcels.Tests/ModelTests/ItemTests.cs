using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetInstanceOfDimension_Item_Int()
    {
      Item newItem = new Item();
      int[] dimension = { 10, 15, 20 };
      newItem.Dimension = dimension;
      int[] result = newItem.Dimension;
      CollectionAssert.AreEqual(dimension, result);
    }

    [TestMethod]
    public void GetInstanceOfWeight_Item_Int()
    {
      Item newItem = new Item();
      int weight = 10;
      newItem.Weight = weight;
      int result = newItem.Weight;
      Assert.AreEqual(weight, result);
    }

      [TestMethod]
    public void SetWeight_Weight_Int()
    {
      Item newItem = new Item();
      int weight2 = 20;
      newItem.Weight = weight2;
      int result = newItem.Weight;
      Assert.AreEqual(weight2, result);
    }

    [TestMethod]
    public void SetDimension_Dimension_Int()
    {
      Item newItem = new Item();
      int[] dimension = { 10, 15, 20 };
      int[] updatedDimension = { 8, 10, 12 };
      newItem.Dimension = updatedDimension;
      int[] result = newItem.Dimension;
      CollectionAssert.AreEqual(updatedDimension, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> { };
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      int[] dimension1 = { 10, 15, 20 };
      int weight1 = 10;
      int[] dimension2 = { 8, 10, 12 };
      int weight2 = 15;
      Item newItem1 = new Item(dimension1, weight1);
      Item newItem2 = new Item(dimension2, weight2);
      List<Item> newList = new List<Item> { newItem1, newItem2};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Volume_MultipleAllSidesOfThePackage_Int()
    {
      int[] dimension = { 10, 15, 20 };
      int weight = 20;
      Item newItem = new Item(dimension, weight);
      Assert.AreEqual(3000, newItem.Volume());
    }

    [TestMethod]
    public void CostToShip_CalculateTheShippingCost_Int()
    {
      int[] dimension = { 10, 15, 20 };
      int weight = 20;
      Item newItem = new Item(dimension, weight);
      Assert.AreEqual(30, newItem.CostToShip());
    }
  }
}