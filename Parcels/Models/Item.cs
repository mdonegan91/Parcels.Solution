using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Item
  {
    public int[] Dimension { get; set; }
    public int Weight {get; set;}

    private static List<int[]> _instances = new List<int[]> { };

    public Item()
    {

    }
    public Item(int[] dimension, int weight)
    {
      Dimension = dimension;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<int[]> GetAll()
    {
      return _instances;
    }
  }
}

