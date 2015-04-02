using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  class Character
  {
    public string name { get; set; }
    public int level { get; set; }
    public int health { get; set; }
    public Character(string Name, int Health, int Level)
    {
      name = Name;
      health = Health;
      level = Level;
    }
    public bool isAlive(int health)
    {
      if (health > 0) 
      {
        return true;
      }
      return false;
    }
  }
}
