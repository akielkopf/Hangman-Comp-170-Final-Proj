using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Player : Character
  {
    public Player(string Name, int Health, int Level) 
      : base (Name, Health, Level)
    {
    }
    public Player()
    {
    }
  }
}
