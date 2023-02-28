using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Item
  {
    public int[] Dimension { get; set; }

    private static List<int[]> _instances = new List<int[]> { };

    public Item()
    {

    }
    public Item(int[] dimension)
    {
      Dimension = dimension;
      _instances.Add(dimension);
    }

    public static List<int[]> GetAll()
    {
      return _instances;
    }
  }
}

