using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroCS;

namespace Sophmores_FinalProj
{
	class Program
	{
		static void Main(string[] args)
		{
			// Test create player with custom constructor values

			//StreamReader reader = new StreamReader("gamelogo.txt");
			//while (!reader.EndOfStream) {

			//	Console.WriteLine(reader.ReadLine());
			//}
			//reader.Close();         
			//Console.WriteLine ("_______________________________________________________________________________\n*******************************************************************************\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n;@@@\\;;;@@@@;;;;;@@@\\;;@@@@@@@\\;;@@@@@@@@\\;;;;;;@@@@@@@\\;;@@@\\;;@@\\;;;@@@@@@@\\;\n;@@@\\;;;@@@\\@@\\;;@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@\\;;@@\\;;;@@@\\;;;;;\n;@@@\\;;;@@@\\;\\@@\\@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@@@@@@\\;;;@@@@@@\\;;\n;@@@\\;;;@@@\\;;;\\@@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@\\\\\\@@\\;;;@@@\\;;;;;\n;@@@\\;;;@@@\\;;;;@@@@\\;;;;@@@\\;;;;@@@@@@@@\\;;;;;;;;@@@\\;;;;@@@\\;;@@\\;;;@@@@@@@\\;\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n;;;;;;;@@@@\\;;;;;;;;;;@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;;;;;@@@@@@@\\;;;;;;\n;;;;;;;;@@@@\\;;@@\\;;;@@@\\;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;@@@\\;;;@@@\\;;;;;;;;;;;\n;;;;;;;;;@@@@\\@@@@\\;@@@\\;;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;;@@@\\;;@@@@@@@@@\\;;;;;\n;;;;;;;;;;@@@@@\\;@@@@@\\;;;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;@@@\\;;;;;;;;;;@@@\\;;;;\n;;;;;;;;;;;@@@@\\;;@@@\\;;;;;;@@@@@@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;;;;@@@@@@@@\\;;;;;;\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n*******************************************************************************\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n                                       .\n         .n                   .                 .                  n.\n   .   .dP                  dP                   9b                 9b.    .\n  4    qXb         .       dX                     Xb       .        dXp     t\n dX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\n 9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\n  9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\n   `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\n     `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\n         ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\n                         )b.  .dbo.dP'`v'`9b.odb.  .dX(\n                       ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\n                      dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\n                     dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\n                     9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\n                      `'      9XXXXXX(   )XXXXXXP      `\n                               `b  `       '  d'\n                                             \n                                 Created By:\n            Andy Kielkopf, Scott Patrick, Robert Hernandez, and Irf \n\n\n\n            ");




			// Player mainChar = //GameIntro ();
			string nameP = UI.PromptLine ("Enter Name");
			Player p1 = new Player (nameP, 50, 50);
			Weapon Sword = new Weapon ();
			p1.AddToInventory (Sword, 1);
			p1.DisplayInventoryContents(Sword.type);
			Console.Write (p1.name + ", ");
			Enemy Spider = new Enemy ();
			Spider.name = "Spider";
			Combat.StartCombat (p1, Spider);
			Console.WriteLine ("Congrats on Defeating your first Enemy, {0}!", p1.name);
			HealthPotion poison = new HealthPotion("Spider Venom", "Athough it has a very attractive smell, " +
				"this Potion is poisonous and dangerous to your health", -10);
			Console.WriteLine ("The {0} has dropped {1}, {2}. \n You can now add it to your inventory if you desire."
				, Spider.name, poison.name, poison.description);
			string answer = UI.PromptLine ("Would you like to add to inventory? (yes or no)");
			if (answer == "yes") {
				p1.AddToInventory (poison, 1);
				Console.WriteLine ("{0} has been added to you inventory.", poison.name);
			} else {
				Console.WriteLine ("you have dropped {0}", poison.name);
			}






		}




	}
}
