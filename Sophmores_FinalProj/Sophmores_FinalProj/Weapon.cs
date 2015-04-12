using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Weapon : Item
  {

    public int PhysicalDamage { get; private set; }
    public int MagicalDamage { get; private set; }
    public Weapon(string Name, string Type, string Description, bool Consumable,
                int magicalDamage)
      : base (Name, Type, Description, Consumable)
    {
      PhysicalDamage = Val;
      MagicalDamage = magicalDamage;
      PlayerCanEquip = true;
    }
    public Weapon(Weapon OldWeapon)
    {
      PlayerCanEquip = true;
    }
    public Weapon()
    {
      name = "Rusty Sword";
      description = "An old Rusty Sword...";
      type = "sword";
      PhysicalDamage = 4;
      MagicalDamage = 0;
      PlayerCanEquip = true;
      consumable = false;
    }
  }
}
