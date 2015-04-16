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
      SetBufferSize();

      // Test create player with custom constructor values
      //test
      var reader = FIO.OpenReader(FIO.GetLocation("gamelogo.txt"), "gamelogo.txt");
      while (!(reader.EndOfStream))
      {

        Console.WriteLine(reader.ReadLine());
      }

      reader.Close();
      Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
			Console.Clear ();

			var reader2 = FIO.OpenReader(FIO.GetLocation("gamelogo2.txt"), "gamelogo2.txt");
			while (!(reader2.EndOfStream)) {

				Console.WriteLine(reader2.ReadLine());
			}
			reader2.Close();

      // Player mainChar = //GameIntro ();
      Player p1 = GameIntro.Start(new Player());
      Console.Write(p1.name + ", ");
      Enemy Spider = new Enemy();
      Spider.name = "Spider";
      Combat.StartCombat(p1, Spider);
      Console.WriteLine("Congrats on Defeating your first Enemy, {0}!", p1.name);
      HealthPotion poison = new HealthPotion("Spider Venom", "athough it has a very attractive smell, " +
        "\nthis Potion is poisonous and dangerous to your health", -10);
      Console.WriteLine("The {0} has dropped {1}, {2}. \n You can now add it to your inventory if you desire."
        , Spider.name, poison.name, poison.description);
      string answer = UI.PromptLine("Would you like to add to inventory? (yes or no)");
      if (answer == "yes")
      {
        p1.AddToInventory(poison, 1);
        Console.WriteLine("{0} has been added to you inventory.", poison.name);
      }
      else
      {
        Console.WriteLine("you have dropped {0}", poison.name);
      }

      Console.WriteLine ("{0}, good job on your combat training, \n we are now ready to venture" +
				" into the tunnel. \nIt will be challening, but after seeing your skills, \nI trust you will bring peace to the woods.", p1.name);
			string forward = UI.PromptLine ("Are you ready to journey into the tunnel? (yes or no)");
			if (forward == "yes") {
				Console.WriteLine ("Good to hear, we are now entering the cave.");
			} else {
				Console.WriteLine ("You're coming anyways... were walking into the tunnel.");
			}
			Console.WriteLine ("Its seems we have come to a fork. There are 4 doors ahead of us." +
			"\n Look! there's a note on the wall.");
			string noteDescription = Note ();
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

		public static string Note()
		{
      string note = string.Empty;
			var reader = FIO.OpenReader(FIO.GetLocation("note.txt"), "note.txt");
			while (!(reader.EndOfStream)) {

        note = reader.ReadLine();
				Console.WriteLine(note);
			}
			reader.Close();
      return note;
		}
    /// <summary>
    /// Sets Buffer Size (within the console that is in the output)
    /// </summary>
    private static void SetBufferSize()
    {
      Console.BufferHeight = (Int16.MaxValue - 1);
      Console.BufferWidth = (80);
    }
  }
}
