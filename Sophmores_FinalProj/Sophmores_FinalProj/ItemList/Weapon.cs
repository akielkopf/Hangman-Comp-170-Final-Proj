﻿namespace Sophmores_FinalProj
{ 
  /// <summary>
  /// Weapons Inherit from Item class All weapons are Equippable By
  /// Default weapons are not consumable
  /// </summary>
  public class Weapon : Item
  {
    #region Public Properties
    /// <summary>
    /// Weapon Magical Damage
    /// </summary>
    public int magicalDamage { get; private set; }
    /// <summary>
    /// Weapon Physical Damage
    /// </summary>
    public int physicalDamage { get; private set; }

    #endregion Public Properties

    #region Public Constructors

    /// <summary>
    /// Create a Custom Weapon, inherhits Item 
    /// </summary>
    /// <param name="Name"> Weapon Name </param>
    /// <param name="Type"> Weapon Type </param>
    /// <param name="Description"> Weapon Description </param>
    /// <param name="PhysicalDamage"> Physical Damage Value </param>
    /// <param name="MagicalDamage"> Magical Damage Value </param>
    public Weapon(string Name, string Type, string Description,
                  int PhysicalDamage, int MagicalDamage)
      : base(Name, Type, Description)
    {
      physicalDamage = PhysicalDamage;
      magicalDamage = MagicalDamage;
      playerCanEquip = true;
      consumable = false;
    }

    /// <summary>
    /// Create new weapon from old weapon 
    /// </summary>
    /// <param name="OldWeapon"> Weapon to Copy </param>
    public Weapon(Weapon OldWeapon)
      : base(OldWeapon)
    {
      physicalDamage = OldWeapon.physicalDamage;
      magicalDamage = OldWeapon.magicalDamage;
    }

    /// <summary>
    /// Create An Old Rusty Sword, starter weapon 
    /// </summary>
    public Weapon()
    {
      name = "Rusty Sword";
      description = "An old Rusty Sword...";
      type = "Sword";
      physicalDamage = 4;
      magicalDamage = 0;
      playerCanEquip = true;
      consumable = false;
    }

    #endregion Public Constructors
  }
}
