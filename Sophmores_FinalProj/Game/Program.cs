using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  class Program
  {
    static void Main(string[] args)
    {
      // Test create player with custom constructor values
      Player p1 = new Player("George", 10, 10);
      Console.WriteLine(p1.name);

      // Test player "conversation" command
      p1.Emote("Hello");
        //test
      // Test create generic non-combat character
      Character NPC1 = new Character();
      if (NPC1.isAlive())
      {
        Console.WriteLine(NPC1.name + " is alive");
      }

      // Test create generic player
      Player p2 = new Player();
      if (p2.isAlive())
      {
        Console.WriteLine("player 2 " + p2.name + " is alive");
        Console.WriteLine("player 2 {0} has {1} health", p2.name, p2.totalHP);
      }

      // Test create Axe with placeholders for constructors
      Weapon Axe = new Weapon("axe of smashing", "two-handed axe", "this axe smashes things", 10, 0);
      Console.WriteLine(Axe.name);
      if (Axe.playerCanEquip)
      {
        Console.WriteLine("{0} can be equiped.",Axe.name);
      }
      // Test create inventory with placeholder items added
      Inventory inv = new Inventory();
      Weapon magicbow = new Weapon("MagicBow", "Bow", "A magical bow", 5, 1);

      //string magicArrow = "magical arrows";

      inv.Add(magicbow, 1);

      //inv.Add(magicArrow, 5);

      // Maybe add this to inventory as a func?
      // Display inventory as Aplhabetical list
      // Still need to add numbered list to select item to equip/use
      var dicList = new List<dynamic>(inv.contents.Keys);
      dicList.Sort();
      foreach (Weapon s in dicList)
      {
        Console.WriteLine(s.name);
        Console.WriteLine(inv.contents[s]);
      }
      // Test Remove items until no more of said item remain
      for (int i = 0; i < inv.contents.Count; i++)
      {
        inv.Remove(magicbow, 1);
      }

      // Test Remove item not in inventory
      //inv.Remove("magicShield", 1);

      // Create new bag, add items to it, test that cannot add more items 
      // Than capacity of bag
      Quiver testbag = new Quiver();
      Weapon SteelArrow = new Weapon("Steel Arrow", "Arrow", "A Good Arrow", 5, 0);
      testbag.Add(SteelArrow, 7);
      testbag.ArrowsInQuiver();
      testbag.Remove(SteelArrow, 12);
      testbag.ArrowsInQuiver();

      // Test Equip and Unequip player functions
      p1.Equip(SteelArrow);
      Console.WriteLine("player one is wielding " + p1.EquippedWeapon.name);
      p1.UnEquip();
      Console.WriteLine("player one is wielding " + p1.EquippedWeapon.name);

      // Test Inspect Functions
      p1.Inspect(Axe);
      p1.Inspect(p1.EquippedWeapon);

      // So console doesn't auto close
      string abc = Console.ReadLine();
    }
  }
}
