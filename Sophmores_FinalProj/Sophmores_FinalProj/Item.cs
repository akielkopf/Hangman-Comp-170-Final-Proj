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
<<<<<<< HEAD
    public bool PlayerCanEquip { get; protected set; }
    public bool consumable { get; protected set; } 
=======
    public bool playerCanEquip { get; protected set; }
    public bool consumable { get; protected set; }
    /// <summary>
    /// Creates a new Item, can be Consumable
    /// </summary>
    /// <param name="Name">Item Name</param>
    /// <param name="Type">Type of Item as a string</param>
    /// <param name="Description">Item Flavor Text</param>
    /// <param name="Consumable">Is this item destroyed when used?</param>
>>>>>>> Rhernandez513/develop(branch-from-this-one)
    public Item(string Name, string Type, string Description, bool Consumable)
    {
      name = Name;
      type = Type;
      description = Description;
      consumable = Consumable;
    }
    /// <summary>
    /// Creates a new Non-Consumable Item
    /// </summary>
    /// <param name="Name">Item Name</param>
    /// <param name="Type">Item Type as a string</param>
    /// <param name="Description">Item Description</param>
    public Item(string Name, string Type, string Description)
    {
      name = Name;
      type = Type;
      description = Description;
    }
    /// <summary>
    /// If you create an Item using this on purpose, you're wrong
    /// </summary>
    public Item()
    {
      name = "ITEM NOT PROPERLY IMPLEMENTED";
    }
  }
}
