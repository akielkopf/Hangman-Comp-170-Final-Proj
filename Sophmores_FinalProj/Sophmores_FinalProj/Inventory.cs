using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Inventory
  {
    public Dictionary<string, int> contents { get; private set; }
    public Inventory()
    {
      contents = new Dictionary<string, int>();
    }
    /// <summary>
    /// Create new inventory from one that already exists
    /// </summary>
    /// <param name="OldInventory">Inventory to be copied from</param>
    public Inventory (Inventory OldInventory)
    {
      if (OldInventory != null)
      {
        contents = new Dictionary<string, int>(OldInventory.contents);
       // OldInventory.contents.
      }
    }
    /// <summary>
    /// Add Item to inventory
    /// </summary>
    /// <param name="ItemName">Name of item as string</param>
    /// <param name="ItemCount">Number of the SAME item to add</param>
    public void Add(string ItemName, int ItemCount)
    {
      if (contents.ContainsKey(ItemName))
      {
        contents[ItemName] += ItemCount;
      }
      else
      {
        contents.Add(ItemName, ItemCount);
      }
    }
    /// <summary>
    /// Removes specified amount of Items(as a string) 
    /// </summary>
    /// <param name="ItemName">Item's name as a string</param>
    /// <param name="ItemCount">Number of items to Remove</param>
    public void Remove(string ItemName, int ItemCount)
    {
      if (contents.ContainsKey(ItemName))
      {
        contents[ItemName] -= ItemCount;
        if (contents[ItemName] <= 0)
        {
          contents.Remove(ItemName);
          Console.WriteLine("You have discarded your last {0}...", ItemName);
        }
      }
      else
      {
        Console.WriteLine("You don't have any of those");
      }
    }
  }
}
