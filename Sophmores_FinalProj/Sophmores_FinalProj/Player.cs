using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Player : Character
  {
    /// <summary>
    /// Contains Methods to Create Players that can
    /// Equip Weapons, and Inspect Items, and more.
    /// Inherits from Character
    /// </summary>
    private Weapon DefaultWeapon;
    public Weapon EquippedWeapon { get; private set; }
    public int PhysicalDamage { get; private set; }
    public int MagicDamage { get; private set; }
    public int TotalDamage { get; private set; }
    public bool TutorialComplete { get; set;}
		public bool Stage1Complete { get; set;}
		public bool Stage2Complete { get; set;}
		public bool Stage3Complete { get; set;}
    public Player(string Name, int Health, int Level) 
      : base (Name, Health, Level)
    {
      PhysicalDamage = 1;
      MagicDamage = 1;
      DefaultWeapon = new Weapon();
      Equip(DefaultWeapon);
      BuffMultiplier = 1;
      int damage = PhysicalDamage + MagicDamage;
      TotalDamage=(int)Math.Round( damage * BuffMultiplier);
      TutorialComplete = false;
    }
    /// <summary>
    /// Creates Default Player named Douglas with basic attributes
    /// </summary>
    public Player()
    {
      Name = "Douglas";
      PhysicalDamage = 1;
      MagicDamage = 1;
      DefaultWeapon = new Weapon();
      Equip(DefaultWeapon);
      BuffMultiplier = 1;
      int damage = PhysicalDamage + MagicDamage;
      TotalDamage = (int)Math.Round(damage * BuffMultiplier);
      TutorialComplete = false;
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
        InspectWeapon(item as Weapon);
      }
      else if (item is HealthPotion)
      {
        InspectPotion(item as HealthPotion);
      }
      else if (item is Key)
      {
        InspectKey(item as Key);
      }
      else if (item is Quiver)
      {
        InspectQuiver(item as Quiver);
      }
    }
    private void InspectPotion(HealthPotion potion)
    {
      Console.WriteLine("Potency: {0}", potion.Potency);
    }
    private void InspectKey(Key key)
    {
      Console.WriteLine("What does this key open...?");
    }
    private void InspectQuiver(Quiver quiver)
    {
      Console.WriteLine("Capacity: {0}", quiver.capacity);
      quiver.ArrowsInQuiver();
    }
    private void InspectWeapon(Weapon weapon)
    {
      Console.WriteLine("Physical Damage: {0}", weapon.physicalDamage);
      Console.WriteLine("Magical Damage: {0}", weapon.magicalDamage);
    }
    /// <summary>
    /// Displays Inventory or specific Item types to Player
    /// </summary>
    /// <param name="itemType">Types of items to show</param>
    public void DisplayInventoryContents(string itemType)
    {
      itemType.ToLower();
      if (itemType == "sword" || itemType == "axe"   ||
          itemType == "bow"   || itemType == "arrow" ||
          itemType == "shield" )
      {
        itemType = "weapon";
      }
      else
      {
        string message = string.Format("That item type {0} is not a " + 
                                       "supported item type!", itemType);
        Console.WriteLine(message);
        throw new NotSupportedException(message);
      }
      var inventoryList = new List<Item>(inventory.contents.Keys);
      inventoryList.Sort();
      if (itemType == "weapon")
      {
        DisplayWeapons(inventoryList);
      }
      else if (itemType == "key")
      {
        DisplayKeys(inventoryList);
      }
      else if (itemType == "potion")
      {
        DisplayPotions(inventoryList);
      }
      else if (itemType == "item")
      {
        DisplayItems(inventoryList);
      }
    }
    /// <summary>
    /// Displays ALL Inventory Contents to Player
    /// </summary>
    public void DisplayInventoryContents()
    {
      var inventoryList = new List<Item>(inventory.contents.Keys);
      inventoryList.Sort();
      DisplayItems(inventoryList);
    }
    private void DisplayItems(List<Item> itemList)
    {
      foreach (Item s in itemList)
      {
        Console.WriteLine("All Items:");
        Console.WriteLine(s.name + " " + inventory.contents[s]);
      }
    }
    private void DisplayWeapons(List<Item> weaponList)
    {
      foreach (Weapon s in weaponList)
      {
        Console.WriteLine("Weapons:");
        Console.WriteLine(s.name + " " + inventory.contents[s]);
      }
    }
    private void DisplayKeys(List<Item> keyList)
    {
      foreach (Key s in keyList)
      {
        Console.WriteLine("Keys:");
        Console.WriteLine(s.name + " " + inventory.contents[s]);
      }
    }
    private void DisplayPotions(List<Item> potionList)
    {
      foreach(HealthPotion s in potionList)
      {
      Console.WriteLine("Potions:");
      Console.WriteLine(s.name + " " + inventory.contents[s]);
      }
    }
    public void DisplayConsumables()
    {
      string x = "Consumables: ";
      StringBuilder builder = new StringBuilder(x);
      foreach(KeyValuePair<Item, int> a in inventory.contents)
      {
        if (a.Key.consumable)
        {
         builder.AppendLine(a.Key.name + ", " + a.Value);
        }
      }
      Console.WriteLine(""+builder);
    }
  }
}
