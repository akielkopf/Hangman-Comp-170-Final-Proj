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
    public int health { get; set; }
    public string affinity { get; set; } 
    public Character(string Name, int Health, int Level, string Affinity)
    {
      name = Name;
      health = Health;
      level = Level;
      affinity = Affinity;
    }
    public Character()
    {
      name = "Douglas";
      health = 100;
      level = 1;
      affinity = "n";
    }
    public bool isAlive()
    {
      if (health > 0) 
      {
        return true;
      }
      return false;
    }
    public void Emote(string says)
    {
      Console.WriteLine(this.name + " says: {0}", says);
    }
    public void deltaHP(int delta) 
    {
        health += delta;
    }
  }
}
