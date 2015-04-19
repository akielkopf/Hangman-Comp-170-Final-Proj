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
    public string Name { get; set; }
    /// <summary>
    /// Doesn't do anything...yet
    /// </summary>
    public int Level { get; set; }
    public int TotalHP { get; set; }
    public int CurrentHP { get; set; }
    public double BuffMultiplier { get; set; }
    public Inventory inventory { get; set; }

    /// <summary>
    /// Creates an Non-Player, Non-Combat Character
    /// </summary>
    /// <param name="Name">Character Name</param>
    /// <param name="Health">Character Health</param>
    /// <param name="Level">Character Level</param>
    public Character(string Name, int Health, int Level)
    {
      this.Name = Name;
      TotalHP = Health;
      CurrentHP = Health;
      this.Level = Level;
      inventory = new Inventory();
    }
    /// <summary>
    /// Creates an Nameable Default Character
    /// Similar to Peasants!
    /// </summary>
    /// <param name="Name">Character Name</param>
    public Character(string Name)
    {
      this.Name = Name;
      TotalHP = 10;
      CurrentHP = TotalHP;
      Level = 1;
      inventory = new Inventory();
    }
    /// <summary>
    /// Default Characters are peasants!
    /// </summary>
    public Character()
    {
      Name = "Peasant";
      TotalHP = 10;
      CurrentHP = TotalHP;
      Level = 1;
      inventory = new Inventory();
    }
    /// <summary>
    /// Check to see if a Character is Alive
    /// </summary>
    /// <returns>True is character is alive, false otherwise</returns>
    public bool isAlive()
    {
      if (CurrentHP > 0) 
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
      Console.WriteLine(this.Name + " says: {0}", says);
    }
    /// <summary>
    /// Use this Function to modify Character Health in-combat
    /// </summary>
    /// <param name="delta">Amount to increase or decrease CurrentHP</param>
    public void ModifyCurrentHP(int delta)
    {
      CurrentHP += delta;
      if (CurrentHP < 0)
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
          if(CurrentHP > TotalHP)
          {
            CurrentHP = TotalHP;
          }
          inventory.Remove(a.Key, 1);
          return;
        }
        else if (a.Value <= 0)
        {
          Console.WriteLine("{0} doesn't have any Potions!", Name);
          inventory.contents.Remove(a.Key);
          return;
        }
      }
      Console.WriteLine("{0} doesn't have any Potions!", Name);
    }
    /// <summary>
    /// Applies Specified value to Character BuffMultiplier
    /// </summary>
    /// <param name="buff">Value of new BuffMultiplier</param>
    public void ApplyBuffOrDebuff(double buff)
    {
      BuffMultiplier = buff;
    }
    /// <summary>
    /// Resets BuffMultiplier to 1
    /// </summary>
    public void RemoveBuff()
    {
      BuffMultiplier = 1;
    }
    /// <summary>
    /// Returns Character Name as String
    /// </summary>
    /// <returns>Character Name</returns>
    public override string ToString()
    {
      return this.Name;
    }
  }
}
