using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Inventory
  {
    public Dictionary<Weapon, int> weapons { get; private set; }
    public Dictionary<Item, int> items { get; private set; }
    public Inventory()
    {
      weapons = new Dictionary<Weapon, int>();
      items = new Dictionary<Item, int>();
    }
    /// <summary>
    /// Create new inventory from one that already exists
    /// </summary>
    /// <param name="OldInventory">Inventory to be copied from</param>
    public Inventory (Inventory OldInventory)
    {
      if (OldInventory != null)
      {
          weapons = new Dictionary<Weapon, int>(OldInventory.weapons);
          items = new Dictionary<Item, int>(OldInventory.items);
       // OldInventory.contents.
      }
    }
    /// <summary>
    /// Add Item to inventory
    /// </summary>
    /// <param name="item">item</param>
    /// <param name="itemCount">Number of the SAME item to add</param>
    public void AddItem(Item item, int itemCount)
    {
      if (items.ContainsKey(item))
      {
        items[item] += itemCount;
      }
      else
      {
        items.Add(item, itemCount);
      }
    }
    /// <summary>
    /// Removes specified amount of Items(as a string) 
    /// </summary>
    /// <param name="item">Item</param>
    /// <param name="ItemCount">Number of items to Remove</param>
    public void RemoveItem(Item item, int itemCount)
    {
      if (items.ContainsKey(item))
      {
        items[item] -= itemCount;
        if (items[item] <= 0)
        {
          items.Remove(item);
          Console.WriteLine("You have used your last {0}...", item.name);
        }
      }
      else
      {
        Console.WriteLine("You don't have any of those");
      }
    }
    /// <summary>
    /// Add weapon to weapon inventory
    /// </summary>
    /// <param name="weapon">weapon</param>
    /// <param name="weaponCount">Number of the SAME weapon to add</param>
    public void AddWeapon(Weapon weapon, int weaponCount)
    {
        if (weapons.ContainsKey(weapon))
        {
            weapons[weapon] += weaponCount;
        }
        else
        {
            weapons.Add(weapon, weaponCount);
        }
    }
    /// <summary>
    /// Removes specified amount of weapons
    /// </summary>
    /// <param name="weapon">weapon</param>
    /// <param name="weaponCount">Number of weapons to Remove</param>
    public void RemoveWeapon(Weapon weapon, int weaponCount)
    {
        if (weapons.ContainsKey(weapon))
        {
            weapons[weapon] -= weaponCount;
            if (weapons[weapon] <= 0)
            {
                weapons.Remove(weapon);
                Console.WriteLine("You have used your last {0}...", weapon.name);
            }
        }
        else
        {
            Console.WriteLine("You don't have any of those");
        }
    }
  }
}
