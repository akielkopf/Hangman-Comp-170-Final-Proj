using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Player : Character
  {
    private Weapon DefaultWeapon;
    public Weapon EquippedWeapon { get; private set; }
    public int PhysicalDamage { get; private set; }
    public int MagicDamage { get; private set; }
    public Player(string Name, int Health, int Level) 
      : base (Name, Health, Level)
    {
      PhysicalDamage = 1;
      MagicDamage = 1;
      DefaultWeapon = new Weapon();
      Equip(DefaultWeapon);
    }
    public Player()
    {
      name = "Douglas";
    }
    /// <summary>
    /// Equips specified weapon by creating new instance of said 
    /// Weapon and changing player EquippedWeapon Reference
    /// </summary>
    /// <param name="WeapontoEquip">Weapon the player will equip</param>
    public void Equip(Weapon WeapontoEquip)
    {
      if (WeapontoEquip.playerCanEquip)
      {
      EquippedWeapon = new Weapon(WeapontoEquip);
      PhysicalDamage += WeapontoEquip.physicalDamage;
      MagicDamage += WeapontoEquip.magicalDamage;
      }
      else
      {
        Console.WriteLine("You can't Equip that!");
      }
    }
    /// <summary>
    /// Unequips currently Equipped Weapon and Equips the Default Weapon
    /// Player will never not have Weapon Equipped
    /// </summary>
    public void UnEquip()
    {
      PhysicalDamage -= EquippedWeapon.physicalDamage;
      MagicDamage -= EquippedWeapon.magicalDamage;
      EquippedWeapon = DefaultWeapon;
    }
    private void InspectWeapon(Weapon weapon)
    {
      Console.WriteLine("Physical Damage: {0}", weapon.physicalDamage);
      Console.WriteLine("Magical Damage: {0}", weapon.magicalDamage);
    }
    /// <summary>
    /// For Players to read Item Descriptions
    /// </summary>
    /// <param name="item">Item to Describe</param>
    public void Inspect(Item item)
    {
      Console.WriteLine("Name: {0}", item.name);
      Console.WriteLine("Type: {0}", item.type);
      Console.WriteLine("Description: {0}", item.description);
      if (item is Weapon)
      {
        InspectWeapon((Weapon)item);
      }
    }
  }
}
