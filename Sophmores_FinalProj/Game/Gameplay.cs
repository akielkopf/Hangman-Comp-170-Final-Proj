using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroCS;
using Sophmores_FinalProj.Utilities;

namespace Sophmores_FinalProj
{
  class Program
  {
    static void Main(string[] args)
    {
      TextUtil.SetBufferSize();
      TextUtil.PrintTextFile("gamelogo.txt");
      TextUtil.PressAnyKeyBufferClear();
      TextUtil.PrintTextFile("gamelogo2.txt");
			Player p1 = GameIntro.Start(new Player());
			Console.Write (p1.Name + ", ");
			Enemy Spider = new Enemy ();
			Spider.Name = "Spider";
			Combat.StartCombat (p1, Spider);
      p1.TutorialComplete = true;
			Console.WriteLine ("Congrats on Defeating your first Enemy, {0}!", p1.Name);
			HealthPotion poison = new HealthPotion("Spider Venom", "athough it has a very attractive smell, " +
				"\nthis Potion is poisonous and dangerous to your health", -10);
			Console.WriteLine ("The {0} has dropped {1}, {2}. \n You can now add it to your inventory if you desire."
				, Spider.Name, poison.name, poison.description);
			string answer = UI.PromptLine ("Would you like to add to inventory? (yes or no)");
			if (answer == "yes") {
				p1.AddToInventory (poison, 1);
				Console.WriteLine ("{0} has been added to you inventory.", poison.name);
			} else {
				Console.WriteLine ("you have dropped {0}", poison.name);
      }

      Console.WriteLine ("{0}, good job on your combat training, \n we are now ready to venture" +
				" into the tunnel. \nIt will be challening, but after seeing your skills, \nI trust you will bring peace to the woods.", p1.Name);
			string forward = UI.PromptLine ("Are you ready to journey into the tunnel? (yes or no)");
			if (forward == "yes") {
				Console.WriteLine ("Good to hear, we are now entering the cave.");
			} else {
				Console.WriteLine ("You're coming anyways... were walking into the tunnel.");
			}
			Console.WriteLine ("Its seems we have come to a fork. There are 4 doors ahead of us." +
			"\n Look! there's a note on the wall.");
			string noteDescription = TextUtil.PrintAndReturnTextFile("note.txt");
			Item note = new Item ("Note", "Paper", noteDescription);
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
      //}
			}
  }
}
