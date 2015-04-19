using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sophmores_FinalProj.Utilities;

namespace Sophmores_FinalProj
{
  public class Character
  {
    /// <summary>
    /// Base Character Class for all types of Characters
    /// Come with Inventories and supporting methods 
    /// Can die, and even Emote!
    /// </summary>
    public string name { get; set; }
    public int level { get; set; }
    public int totalHP { get; set; }
    public int currentHP { get; set; }
    public Inventory inventory { get; set; }

    /// <summary>
    /// Creates an Non-Player, Non-Combat Character
    /// </summary>
    /// <param name="Name">Character Name</param>
    /// <param name="Health">Character Health</param>
    /// <param name="Level">Character Level</param>
    public Character(string Name, int Health, int Level)
    {
      name = Name;
      totalHP = Health;
      currentHP = Health;
      level = Level;
      inventory = new Inventory();
    }
    /// <summary>
    /// Default Characters are peasants!
    /// </summary>
    public Character()
    {
      name = "Peasant";
      totalHP = 10;
      currentHP = totalHP;
      level = 1;
      inventory = new Inventory();
    }
    /// <summary>
    /// Check to see if a Character is Alive
    /// </summary>
    /// <returns>True is character is alive, false otherwise</returns>
    public bool isAlive()
    {
      if (currentHP > 0) 
      {
        return true;
      }
      return false;
    }
    /// <summary>
    /// Add Item to inventory
    /// </summary>
    /// <param name="item">item</param>
    /// <param name="itemCount">Number of the SAME item to add</param>
    public void AddToInventory(Item item, int itemCount)
    {
      inventory.Add(item, itemCount);
    }
    /// <summary>
    /// Removie an Item from the character's Inventory
    /// </summary>
    /// <param name="item">Item to Remove</param>
    /// <param name="itemCount">Number of Items to Remove</param>
    public void RemoveFromInventory(Item item, int itemCount)
    {
      inventory.Remove(item, itemCount);
    }
    /// <summary>
    /// For use when a character says something
    /// </summary>
    /// <param name="says">Thing the character says</param>
    public void Emote(string says)
    {
      Console.WriteLine(this.name + " says: {0}", says);
    }
    /// <summary>
    /// Use this Function to modify Character Health in-combat
    /// </summary>
    /// <param name="delta">Amount to increase or decrease CurrentHP</param>
    public void ModifyCurrentHP(int delta)
    {
      currentHP += delta;
      if (currentHP < 0)
      {
        isAlive();
      }
    }
    /// <summary>
    /// Uses the first healthpotion in the Inventory
    /// </summary>
    public void UseHealthPotion()
    {
      foreach(KeyValuePair<Item, int> a in inventory.contents)
      {
        if (a.Key is HealthPotion &&
            a.Value > 0           &&
            a.Key.consumable == true)
        {
          ModifyCurrentHP(((HealthPotion)a.Key).Potency);
          if(currentHP > totalHP)
          {
            currentHP = totalHP;
          }
          inventory.Remove(a.Key, 1);
          return;
        }
        else if (a.Value <= 0)
        {
          Console.WriteLine("{0} doesn't have any Potions!", name);
          inventory.contents.Remove(a.Key);
          return;
        }
      }
      Console.WriteLine("{0} doesn't have any Potions!", name);
    }
  }
}
