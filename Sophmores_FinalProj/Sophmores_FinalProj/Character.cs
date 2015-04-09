using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Character
  {
    public string name { get; set; }
    public int level { get; set; }
    public int totalHP { get; set; }
    public int currentHP { get; set; }
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
    /// For use when a character says something
    /// </summary>
    /// <param name="says">Thing the character says</param>
    public void Emote(string says)
    {
      Console.WriteLine(this.name + " says: {0}", says);
    }
    /// <summary>
    /// Use this Function to modify Character Health in-combat or with Potions
    /// </summary>
    /// <param name="delta">Amount to increase or decrease CurrentHP</param>
    public void ModifyDeltaHealth(int delta)
    {
      if (delta > 0)
      {
        currentHP += delta;
      }
      else
      {
        currentHP -= delta;
      }
    }
  }
}
