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
    }
  }
}
