using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

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
      List<int[]> newList = new List<int[]> { };
      List<int[]> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      int[] dimension1 = { 10, 15, 20 };
      int[] dimension2 = { 8, 10, 12 };
      Item newItem1 = new Item(dimension1);
      Item newItem2 = new Item(dimension2);
      List<int[]> newList = new List<int[]> { dimension1, dimension2 };
      List<int[]> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}