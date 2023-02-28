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
      int[] dimension = {10, 15, 20};
      newItem.Dimension = dimension;
      int[] result = newItem.Dimension;
      CollectionAssert.AreEqual(dimension, result);
    }

    [TestMethod]
    public void SetDimension_Dimension_Int()
    {
      Item newItem = new Item();
      int[] dimension = {10, 15, 20};
      int[] updatedDimension = {8, 10, 12};
      newItem.Dimension = updatedDimension;
      int[] result = newItem.Dimension;
      CollectionAssert.AreEqual(updatedDimension, result);
    }
  }
}