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
      Player p1 = new Player("George", 10, 10);
      Console.WriteLine(p1.name);
      p1.Emote("Hello");
      Character NPC1 = new Character();
      if (NPC1.isAlive())
      {
        Console.WriteLine(NPC1.name + "is alive");
      }
      Player p2 = new Player();
      if (p2.isAlive())
      {
        Console.WriteLine("player 2 " + p2.name + " is alive");
      }
      Weapon Axe = new Weapon();
      if (Axe.PlayerCanEquip)
      {
        Console.WriteLine("Player cannot equip");
      }
      Console.WriteLine(Axe.name);
      var testdictionary = new Dictionary<string, int>();
      Inventory inv = new Inventory();
      string magicbow = "magical bow";
      string magicArrow = "magical arrows";
      inv.Add(magicbow, 1);
      inv.Add(magicArrow, 5);
      //maybe add thhis to inventory as a func?
      var dicList = new List<string>(inv.contents.Keys);
      dicList.Sort();
      foreach (string s in dicList)
      {
        Console.WriteLine(s);
        Console.WriteLine(inv.contents[s]);
      }
      for (int i = 0; i < inv.contents.Count; i++)
      {
        inv.Remove(magicbow, 1);
      }
      inv.Remove("magicShield", 1);
    }
  }
}
