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
			TextUtil.SetBufferSize ();
			TextUtil.PrintTextFile ("gamelogo.txt");
			TextUtil.PressAnyKeyBufferClear ();
			TextUtil.PrintTextFile ("gamelogo2.txt");
			Player p1 = GameIntro.Start (new Player ("", 100, 10));
			Console.Write (p1.Name + ", ");
			Enemy Spider = new Enemy ();
			Spider.Name = "Small Spider";
			Combat.StartCombat (p1, Spider);
			p1.TutorialComplete = true;
			Console.WriteLine ("Congrats on Defeating your first Enemy, {0}!", p1.Name);
			Poison venom = new Poison ("Spider Venom", "athough it has a very attractive smell, " +
			                      "\n this venom will weaken anyone who touches it.", false);
			Console.WriteLine ("The {0} has dropped {1}, {2}. \n You can now add it to your inventory if you desire."
				, Spider.Name, venom.name, venom.description);
            int answer = getChoice(2, "Would you like to add to inventory? \n 1) Yes \n 2) No)\n");
			if (answer == 1) {
				p1.AddToInventory (venom, 1);
				Console.WriteLine ("{0} has been added to you inventory.", venom.name);
			} else {
				Console.WriteLine ("you have dropped {0}", venom.name);
			}

			Console.WriteLine ("{0}, good job on your combat training, \n we are now ready to venture" +
			" into the tunnel. \nIt will be challening, but after seeing your skills, \nI trust you will bring peace to the woods.", p1.Name);
            int forward = getChoice(2, "Are you ready to journey into the tunnel? \n 1) Yes \n 2) No)\n");
			if (forward == 1) {
				Console.WriteLine ("Good to hear, we are now entering the cave.");
			} else {
				Console.WriteLine ("You're coming anyways... were walking into the tunnel.");
			}
			Console.WriteLine ("Its seems we have come to a fork. There are 4 doors ahead of us." +
			"\n Look! there's a note on the wall.");
			string noteDescription = TextUtil.ReturnTextFile ("note.txt");
			Item note = new Item ("Note", "Paper", noteDescription);
			int response = getChoice (2," Would you like to: \n 1) Take a Look \n 2) Add to Inventory");
			if (response == 1) {
				Console.WriteLine(note.description);
				Console.WriteLine ("\n\n**Hmmmm, kind of odd that the name at the bottom is ripped off**\n\n");
			} else {
				p1.AddToInventory (note, 1);
			}
			p1.AddToInventory (note, 1);
			Console.WriteLine ("Well lets not take too long, lets start finding keys!\n");
			bool responseIsGood = false;
			while (!(responseIsGood)) {
				response = getChoice (4,"Which door would you like to enter? \n 1) Door 1 \n 2) Door 2 \n 3) Door 3 \n 4) Open Inventory \n");
				if (p1.currentStage == 0 &&     //Stage 1 starts here
					response != 4) {
					if (OpenedDoors(response, p1) == true) {
						p1.Stage = true;
						Console.WriteLine ("Okay, we are going into door {0}", response);
						Enemy skeleton = new Enemy ("Skeleton", 10, 1, 5, 6);
						Weapon IronSword = new Weapon ("Iron Sword", "sword", "sword made of iron", 10, 0);
						HealthPotion skeleFluid = new HealthPotion ("Skeleton Fluid", "Fluid from a skeleton... it looks nutritious", false);
						skeleton.AddToInventory (IronSword, 1);
						skeleton.AddToInventory (skeleFluid, 2);

						Enemy goblin = new Enemy ("Goblin", 20, 2, 7, 9);
						Weapon SteelSword = new Weapon ("#blessed Steel Sword", "sword", "sword made of steel, with slight magic damage", 15, 10);
						HealthPotion GoblinBlood = new HealthPotion ("Goblin Blood", "blood from the heart of the Goblin", false);
						goblin.AddToInventory (SteelSword, 1);
						goblin.AddToInventory(GoblinBlood, 2);

						Enemy giant = new Enemy ("Giant", 35, 3, 10, 13);
						Weapon BasicBow = new Weapon ("BasicBow", "bow", "basic wooden bow", 20, 0);
						HealthPotion GiantMagic = new HealthPotion ("Giant Magic", "magic potion used by the Giant to cure his injuries", true);
						Item key1 = new Item ("Key I", "key", "this is the key colloected from first stage");
						giant.AddToInventory (key1, 1);
						giant.AddToInventory (BasicBow, 1);
						giant.AddToInventory(GiantMagic, 1);

						DoorStage (p1, skeleton, goblin, giant);
                        Console.WriteLine("After defeating the giant, you leave the room. You hear \n the door lock behind you as you step into the lobby.");
						p1.Stage1Complete = true;    ////Stage 1 ends here
						p1.currentStage = 1;
						p1.Stage = false;
						continue;

					} else if (p1.Stage1Complete) {
                        Console.WriteLine("The door is sealed shut");
						continue;
					}
				}
				else if (p1.currentStage == 1 &&
					response != 4) {
					if (OpenedDoors(response, p1) == true) 
					{
						Console.WriteLine ("Okay, we are going into door {0}", response);
						Enemy GiantSpider = new Enemy ("Giant Spider", 20, 10, 5, 7);
						Enemy alligator = new Enemy ("Alligator", 20, 10, 5, 7);
						Enemy kraken = new Enemy ("Kraken", 20, 10, 5, 7);
						Item key2 = new Item ("Key II", "key", "this is the key collected from second stage");
						kraken.AddToInventory (key2, 1);
						DoorStage (p1, GiantSpider, alligator, kraken);
						p1.Stage2Complete = true;
						p1.currentStage = 2;
						continue;
					} else if (p1.Stage2Complete) {
						response = UI.PromptInt ("You have already completed this Door, choose another.");
						continue;
					}
				} 
				else if (p1.currentStage == 2 &&
					response != 4) {
					if (OpenedDoors(response, p1) == true)  {
						Console.WriteLine ("Okay, we are going into door {0}", response);
						Enemy wolf = new Enemy ("Wolf", 20, 10, 5, 7);
						Enemy zombie = new Enemy ("Zombie", 20, 10, 5, 7);
						Enemy orc = new Enemy ("Orc", 20, 10, 5, 7);
						Item key3 = new Item ("Key III", "key", "this is the key collected from third stage");
						orc.AddToInventory (key3, 1);
						DoorStage (p1, wolf, zombie, orc);
						p1.Stage3Complete = true;
						p1.currentStage = 3;
					} else if (p1.Stage3Complete) {
						response = UI.PromptInt ("You have already completed this Door, choose another.");
						continue;
					}
				}else if (response == 4) {
					p1.DisplayInventoryContents ();
					string input = UI.PromptLine("Spell out the name of Item you wish to see description of. (case doesn't matter)");
					foreach (KeyValuePair <Item, int> a in p1.inventory.contents) {
						if (input.Trim().ToLower() == a.Key.name.Trim().ToLower()) {
							p1.Inspect (a.Key);
						} else {
							input = UI.PromptLine ("There is no item in your inventory that matches that input. Try again.");
						}
					}

				} else if (p1.currentStage == 3 &&
					response != 4)
				{
					responseIsGood = true;
					continue;
				}

			}
		}
		static void DoorStage (Player player, Enemy enemy1, Enemy enemy2, Enemy boss)
		{
			Combat.StartCombat (player, enemy1);
			GainEnemyItems (player, enemy1);

			Combat.StartCombat (player, enemy2);
			GainEnemyItems (player, enemy2);

			Combat.StartCombat (player, boss);
			GainEnemyItems (player, boss);
        }
		static bool OpenedDoors(int response, Player player)
		{
			foreach (int r in player.DoorsOpened) {
				if (response == r) {
					return false;
				}
			}
			player.DoorsOpened.Add (response);
			player.currentDoor = response;
			return true;
		}
		static void GainEnemyItems(Player player, Enemy enemy)
		{
			if (!(enemy.isAlive ())) {
				foreach (KeyValuePair<Item, int> a in enemy.inventory.contents) {
					player.AddToInventory (a.Key, 1);
					Console.WriteLine ("{0} has been added to your inventory!", a.Key.name);
					if (a.Key is Weapon)
					{
						string question = ("Would you like to equip " + a.Key.name + "? \n 1)Yes \n 2)No\n");
						int answer = getChoice(2,question);
						if (answer == 1)
						{
							player.Equip (a.Key as Weapon);
							Console.WriteLine("your new weapon has been equipped!\n");
						}
						else if (answer == 2)
						{
							Console.WriteLine("you have not equipped your newest weapon.\n");
						}
					}
					else if (a.Key is HealthPotion)
					{
						string question = "Would you like to consume "+ a.Key.name +"?, Its desciption is : " + a.Key.description +" \n 1)Yes \n 2)No"; 
                        int answer = getChoice(2, question);
						if (answer == 1)
						{
                            player.consumeItem(a.Key as HealthPotion);
							Console.WriteLine("you have consumed the potion, your current HP is {0}.", player.CurrentHP);
						}
						else if (answer == 2)
						{
							Console.WriteLine("you have decided not to consume the potion.\n");
						}
					}
				}
			}
		}
        static int getChoice(int numChoices, string choices)
        {
            Console.WriteLine(choices);
            int choice = UI.PromptInt("Please enter a choice number: ");
            while (choice < 1 || choice > numChoices)
            {
                Console.WriteLine("{0} is not a valid choice!", choice);
                Console.WriteLine(choices);
                choice = UI.PromptInt("Please enter a valid choice number: ");
            }
            return choice;
        }
	}
}

