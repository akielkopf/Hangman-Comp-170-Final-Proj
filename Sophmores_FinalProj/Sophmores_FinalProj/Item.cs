using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Item
  {
    public string name { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public bool PlayerCanEquip { get; protected set; }
    public bool consumable { get; protected set; }
    public Item(string Name, string Type, string Description, bool Consumable)
    {
      name = Name;
      type = Type;
      description = Description;
      consumable = Consumable;
    }
    /// <summary>
    /// If you create an Item using this on purpose, you're wrong
    /// </summary>
    public Item()
    {
      this.name = "ItemHasNoName";
      Console.WriteLine("ITEM NOT PROPERLY IMPLEMENTED");
    }

    /// <summary>
    /// For Players to read Item Descriptions
    /// </summary>
    /// <param name="item">Item to Describe</param>
  }
}
