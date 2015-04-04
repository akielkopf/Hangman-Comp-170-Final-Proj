using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Weapon : Item
  {
    public bool PlayerCanEquip { get; private set; }
    public Weapon(string Name, string Type, string Description)
      : base (Name, Type, Description)
    {
      PlayerCanEquip = true;
    }
  }
}
