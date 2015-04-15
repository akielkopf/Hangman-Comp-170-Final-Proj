using System;

namespace Sophmores_FinalProj
{
	public static class GameIntro
	{
		public static Player Start(Player mainCharacter)
		{

      PressAnyKeyBufferClear("Press any key to begin your adventure...");

			Console.WriteLine ("You wake up from your sleep to noises coming from outside.\nGaging from the darkness you can see outside you guess that it's midnight." +
				"\nThe lantern on the side table next is still burning.\nYou grab it and head to the window to inspect the sound that came from outside." +
				"\nIt is really foggy out and you can't see past twenty yards.\nYou contemplate to yourself,\n'What could possibly making these noises at this time of night?'" +
				"\nAn animal? Maybe it was just the wind. Was it a robber...");

      PressAnyKeyBufferClear();

			Console.WriteLine ("You hear a ruffle of leaves coming from just past your yard." + "" +
				"\nYou quickly head downstairs and look for something to protect yourself with. \nYou look around and see a shovel." + 
				"\nAs you're about to head to the door you hear a loud yell from outside,\n\"Help, is anyone there?\" You suddenly freeze and chills run down your spine." +
				"\nYou tiptoe to the door and peek outside.\nThe eyehole reveals nothing but darkness. You're hesitant about what to do next.");

      PressAnyKeyBufferClear();

			Console.WriteLine ("Against your consciousness, you decide to head outside.\nThe door creeks loudly as you open it ever so slowly.\nYour lantern doesn't reveal any of the darnkness outside." +
				"\n\"Is anyone out there? I have a shovel and I'm not afraid to use it\",\nyou yell out to the darkness. There is no response." +
				"\nYou stand there for a few minutes, flinching at every sound around you." +
				"\nAll of a sudden there is a rush of footsteps through the leaves towards you.\n\"Stop right there and show yourself!\", you yell out to the darkness.");

      PressAnyKeyBufferClear();

			Console.WriteLine ("\"Hello? I mean no harm.\", a voice from the darkness responds.\nA figure appears a few yards in front of you.\nThey have their hands up and appear as frightened as you are." +
				"\n\"Approach slowly!\", you yell out to the stranger.\nThe stranger slows their pace. There is a long silence as they approach you.\nAs the figure becomes more visible your jaw drops." +
				"\nThe stranger appears to be glowing. To your amazement they seem to be hovering.\nThey seem to be a foot or two of the ground.\nYou can tell the stranger can see your amazement." +
				"\n\"There is nothing to be afraid of.\", the strange figure assures.");

      PressAnyKeyBufferClear();

			Console.WriteLine("\"Who are you and why are you on my land!\", you stammer out to the figure." +
				"\nYou're still pointing your knife at the stranger, afraid of any sudden movement.\n\"There's no need for that.\", the stranger gestures at your knife." +
				"\n\"You couldn't even use it even if you wanted to.\", the stranger continues.\nNot knowing to trust the stranger, you slowly lower your knife." +
				"\n\"My name is Odalf and I've been looking for someone to help me.\",\nOdalf responds to your earlier question.\n\"I've been searching all night in search of someone." +
				"\nIt appears that I have gotten myself into a predicament\", Odalf explains.\n\"Based off your reaction to seeing me, you can tell that I'm a ghost.\"");

      PressAnyKeyBufferClear();

			Console.WriteLine("You gasp in shock. The floating figure does appear to be a ghost.\n\"Sorry for my manners, but I never asked for your name.\nWhat is your name my friend?\", " +
				"asks the ghost." );
			Console.Write("(Please enter in your name) ");
			mainCharacter.name=Console.ReadLine();
			string playerName = mainCharacter.name;

      PressAnyKeyBufferClear();

			Console.WriteLine ("\"My name is " + playerName + ".\", you respond slowly.\n\"How is it exactly that you are a ghost?\", you ask Odalf.\n\"Funny that you would ask that question.\", Odalf says chuckling to himself." +
				"\n\"I appear to have gotten myself into some trouble.\nI was on an adventure and I mistakengly met my fate.\nBut it appears that not all hope is lost.\nI think that if I'm able to get back to my body\nI can get out of this ghastly form.\"," +
				"\nexpalins Odalf.");

      PressAnyKeyBufferClear();

			Console.WriteLine("\"What kind of adventure were you on?\", you ask Odalf.\nThere's a cavern in the woods not too far from here.\nIn it lies a treasure bigger than either you or I can imagine.\", " +
				"Odalf explains.\n\"And you " + playerName + ", are going to help me get the treasure!\"," +
				"\nOdalf explains with excitement.\n\"Me?! There is no way I'm going to this dangerous cavern.\nI don't even know what's there. You died and that's all I need to know!\",\nyou shout at Odalf.");

      PressAnyKeyBufferClear();

			Console.WriteLine ("\"Well that's easy, I can tell you what's in the caverns.\nThere's goblins and trolls and bears and a dragon and-\",\nOdalf explains as you interupt him.\n\"A DRAGON!!!\", you yell out." +
				"\n\"There is absolutely no way I'm going to help you out.\", you shout out at Odalf.\nYou turn to leave and start heading back to your house." +
				"\n\"Please! If you don't help me I may never get back to my body!\", Odalf pleads.\n\"I would like to help you, but I don't know how I'm any help.\",\nyou explain to Odalf." +
				"\n\"I don't know how to fight and there is no way I would be able to survive.\",\n\"That part is simple, I can teach you!\", Odalf exlaims.");

      PressAnyKeyBufferClear();

			return mainCharacter;

			//
		}
    /// <summary>
    /// Prints standard Press Any Key to Continue Message
    /// Then clears the screen
    /// </summary>
    private static void PressAnyKeyBufferClear()
    {
      string message = ("\nPress any key to continue...");
      Console.WriteLine(message);
      Console.ReadKey();
      Console.Clear();
    }
    /// <summary>
    /// Prints custom Press Any Key to Continue message
    /// Then clears the screen
    /// </summary>
    /// <param name="message">Message to display to player</param>
    private static void PressAnyKeyBufferClear(string message)
    {
      Console.WriteLine("\n" + message);
      Console.ReadKey();
      Console.Clear();
    }

	}
}
