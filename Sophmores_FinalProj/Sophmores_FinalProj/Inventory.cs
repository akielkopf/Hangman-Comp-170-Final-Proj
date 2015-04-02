using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Inventory
  {
    private Dictionary<string, int> contents;
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
      else()
        ///////////// continue here
    //        void AddToInventory()
    //{

    //}
    //void RemoveFromInventory()
    //{

    //}
    }
  }
}
