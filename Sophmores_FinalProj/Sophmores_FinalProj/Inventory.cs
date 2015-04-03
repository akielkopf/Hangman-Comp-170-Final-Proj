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
    public Inventory (Inventory OldInventory)
    {
      contents = new Dictionary<string,int>(OldInventory.contents);
    }
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
    //public void Remove(string ItemName, int ItemCount)
    //{
    //  if (contents.ContainsKey(ItemName))
    //  {
    //    contents.Remove(ItemName);
    //  }
    //  else
    //  {

    //  }
    //}
  }
}
