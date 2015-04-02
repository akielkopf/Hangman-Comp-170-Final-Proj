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
      p1.name = "george";
      Console.WriteLine(p1.name);
    }
  }
}
