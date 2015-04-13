using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Weapon : Item
  {
<<<<<<< HEAD
    /// <summary>
    /// Weapons Inherit from Item class
    /// All weapons are Equippable
    /// By default weapons are not consumable
    /// </summary>
    public int physicalDamage { get; private set; }
    public int magicalDamage { get; private set; }
    /// <summary>
    /// Create a Custom Weapon, inherhits Item
    /// </summary>
    /// <param name="Name">Weapon Name</param>
    /// <param name="Type">Weapon Type</param>
    /// <param name="Description">Weapon Description</param>
    /// <param name="PhysicalDamage">Physical Damage Value</param>
    /// <param name="MagicalDamage">Magical Damage Value</param>
    public Weapon(string Name, string Type, string Description, 
                  int PhysicalDamage, int MagicalDamage)
      : base (Name, Type, Description)
=======

    public int PhysicalDamage { get; private set; }
    public int MagicalDamage { get; private set; }
    public Weapon(string Name, string Type, string Description, bool Consumable,
                int magicalDamage)
      : base (Name, Type, Description, Consumable)
>>>>>>> e399a9816fa508843c8f783dd731bf9616837f9f
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
