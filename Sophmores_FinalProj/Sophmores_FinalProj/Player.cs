using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  class Player : Character
  {
    private string Name { get; set; }
    private int Heath { get; set; }
    private int Level {get; set;}
    public Player(string Name, int Health, int Level)
    {
      name = Name;
      health = Health;
      level = Level;
    }
        //public Player(string p1, int p2, int p3)
    //{
    //  // TODO: Complete member initialization
    //  this.p1 = p1;
    //  this.p2 = p2;
    //  this.p3 = p3;
    //}
  }
}
