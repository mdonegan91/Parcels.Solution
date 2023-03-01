using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Item
  {
    public int[] Dimension { get; set; }
    public int Weight { get; set; }

    private static List<Item> _instances = new List<Item>();

    public Item()
    {

    }
    public Item(int[] dimension, int weight)
    {
      Dimension = dimension;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public int Volume()
    {
      int volume = Dimension[0] * Dimension[1] * Dimension[2];
      return volume;
    }

    public double CostToShip()
    {
      double totalCost = 1.50 * Weight;
      return Math.Round(totalCost, 2);
    }
  }
}

