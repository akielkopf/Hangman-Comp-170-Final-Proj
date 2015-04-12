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
    public int DamageAbility { get; private set; }
    public int totalDamage { get; set; }
    public double buff { get; set; }
    public Player(string Name, int Health, int Level, string Affinity) 
      : base (Name, Health, Level, Affinity)
    {
      DamageAbility = 1;      
      affinity = "n";  
      DefaultWeapon = new Weapon();
      Equip(DefaultWeapon);
      buff = 0;
    }
    public Player()
    {
    }
    /// <summary>
    /// Equips specified weapon by REFERENCE
    /// </summary>
    /// <param name="WeapontoEquip">Weapon the player will equip</param>
    public void Equip(Weapon WeapontoEquip)
    {
      if (WeapontoEquip.PlayerCanEquip)
      {
      EquippedWeapon = WeapontoEquip;              
      }
      else
      {
        Console.WriteLine("You can't Equip that!");
      }
    }
    /// <summary>
    /// Unequips currently Equipped Weapon and Equips the Default Weapon
    /// Player will never have no Weapon Equipped
    /// </summary>
    public void UnEquip()
    {
        Equip(DefaultWeapon);
    }
    private void InspectWeapon(Weapon weapon)
    {
      Console.WriteLine("Damage Ability: {0}", weapon.PhysicalDamage);     
    }
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
    public void applyBuff(double Buff) 
    {
        buff = Buff;
        totalDamage = buff * DamageAbility + DamageAbility;
    }
   
  }
}
