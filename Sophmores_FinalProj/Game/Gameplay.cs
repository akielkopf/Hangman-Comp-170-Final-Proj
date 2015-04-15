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
			//test

			var reader = FIO.OpenReader(FIO.GetLocation("gamelogo.txt"), "gamelogo.txt");
			while (!(reader.EndOfStream)) {

				Console.WriteLine(reader.ReadLine());
			}
			reader.Close();         
			//Console.WriteLine ("_______________________________________________________________________________\n*******************************************************************************\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n;@@@\\;;;@@@@;;;;;@@@\\;;@@@@@@@\\;;@@@@@@@@\\;;;;;;@@@@@@@\\;;@@@\\;;@@\\;;;@@@@@@@\\;\n;@@@\\;;;@@@\\@@\\;;@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@\\;;@@\\;;;@@@\\;;;;;\n;@@@\\;;;@@@\\;\\@@\\@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@@@@@@\\;;;@@@@@@\\;;\n;@@@\\;;;@@@\\;;;\\@@@@\\;;;;@@@\\;;;;@@@\\;;@@\\;;;;;;;;@@@\\;;;;@@@\\\\\\@@\\;;;@@@\\;;;;;\n;@@@\\;;;@@@\\;;;;@@@@\\;;;;@@@\\;;;;@@@@@@@@\\;;;;;;;;@@@\\;;;;@@@\\;;@@\\;;;@@@@@@@\\;\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n;;;;;;;@@@@\\;;;;;;;;;;@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;;;;;@@@@@@@\\;;;;;;\n;;;;;;;;@@@@\\;;@@\\;;;@@@\\;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;@@@\\;;;@@@\\;;;;;;;;;;;\n;;;;;;;;;@@@@\\@@@@\\;@@@\\;;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;;@@@\\;;@@@@@@@@@\\;;;;;\n;;;;;;;;;;@@@@@\\;@@@@@\\;;;;;@@@\\;;@@\\;;@@@\\;;@@\\;;@@@\\;;;@@@\\;;;;;;;;;;@@@\\;;;;\n;;;;;;;;;;;@@@@\\;;@@@\\;;;;;;@@@@@@@@\\;;@@@@@@@@\\;;@@@@@@@@\\;;;;;@@@@@@@@\\;;;;;;\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n*******************************************************************************\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\n                                       .\n         .n                   .                 .                  n.\n   .   .dP                  dP                   9b                 9b.    .\n  4    qXb         .       dX                     Xb       .        dXp     t\n dX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\n 9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\n  9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\n   `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\n     `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\n         ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\n                         )b.  .dbo.dP'`v'`9b.odb.  .dX(\n                       ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\n                      dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\n                     dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\n                     9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\n                      `'      9XXXXXX(   )XXXXXXP      `\n                               `b  `       '  d'\n                                             \n                                 Created By:\n            Andy Kielkopf, Scott Patrick, Robert Hernandez, and Irf \n\n\n\n            ");




			// Player mainChar = //GameIntro ();
			Player p1 = GameIntro.Start(new Player());
			Console.Write (p1.name + ", ");
			Enemy Spider = new Enemy ();
			Spider.name = "Spider";
			Combat.StartCombat (p1, Spider);
			Console.WriteLine ("Congrats on Defeating your first Enemy, {0}!", p1.name);
			HealthPotion poison = new HealthPotion("Spider Venom", "athough it has a very attractive smell, " +
				"\nthis Potion is poisonous and dangerous to your health", -10);
			Console.WriteLine ("The {0} has dropped {1}, {2}. \n You can now add it to your inventory if you desire."
				, Spider.name, poison.name, poison.description);
			string answer = UI.PromptLine ("Would you like to add to inventory? (yes or no)");
			if (answer == "yes") {
				p1.AddToInventory (poison, 1);
				Console.WriteLine ("{0} has been added to you inventory.", poison.name);
			} else {
				Console.WriteLine ("you have dropped {0}", poison.name);
			}

			Console.WriteLine ("{0}, good job on your combat training, \n we are now ready to venture" +
				" into the tunnel. \nIt will be challening, but after seeing your skills, \nI trust you will bring peace to the woods.", p1.name);
			string forward = UI.PromptLine ("Are you ready to journey into the tunnel? (yes or no)");
			if (forward == "yes") {
				Console.WriteLine ("Good to hear, we are now entering the cave.");
			} else {
				Console.WriteLine ("Pussy, youre coming anyways... were walking into the tunnel.");
			}
			Item note = new Item ("Note", "Paper", "         \n       ________________________________________\n      |                                        |\n      |           **  WARNING **               |  \n      |                                        |  \n      |      As you can see, there are four    |  \n      |      doors in front of you. behind     |  \n      |      the biggest door is where you     |  \n      |      will find what you are looking    |  \n      |      for. However, in order to get     |  \n      |      access to that door, you will     |  \n      |      need to get all three keys.       |  \n      |      Each of which are being guarded   |  \n      |      By a monster. You will need to    |  \n      |      enter each one of the other 3     |  \n      |      doors and defeat each monster     |  \n      |      to get a hold of the key it       |  \n      |      protects. Many have tried but     |\n      |      so far none have prevailed. I     |  \n      |      wish you the best of luck.        |  \n      |                                        |\n      |                        |\\/\\/\\/\\/\\/\\/\\/\\|    \n      |                    ~~~O|                        \n      |________________________|                     \n                                                    ");
			Console.WriteLine ("Its seems we have come to a fork. There are 4 doors ahead of us." +
			"\n Look! there's a note on the wall.");
			int response = UI.PromptInt (" Would you like to: \n 1) Take a Look \n 2) Add to Inventory \n Enter 1 or 2.");
			if (response == 1) {
				Console.WriteLine (note.description);
				Console.WriteLine ("**Hmmmm, kind of odd that the name at the bottom is ripped off**");
			} else {
				p1.AddToInventory (note, 1);
			}
			Console.WriteLine ("Well lets not take too long, lets start finding keys!");
			response = UI.PromptInt("Which door would you like to enter? \n Door 1 \n Door 2 \n Door 3 \n Enter 1,2, or 3");
			//while (!response == "1" || "2" || "3" ){
				//response = UI.PromptInt ("Please select a Door number.");
			}


		}

	}
