using IntroCS;
using Sophmores_FinalProj.Utilities;
using System;
using System.Text;

namespace Sophmores_FinalProj
{
  public static class GameIntro
  {
    #region Public Methods
    /// <summary>
    /// Plot and Main Character Creation
    /// </summary>
    /// <param name="mainCharacter">
    ///  Main Character is returned with name from player input
    /// </param>
    /// <returns></returns>
    public static Player CharacterCreation(Player mainCharacter)
    {
      string line = CreateLine();

      TextUtil.PressAnyKeyBufferClear("Press any key to begin your adventure...");

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("You wake up from your sleep to noises coming from " +
        "outside.\n\nGaging from the darkness you can see outside you guess " +
        "that it's midnight. \n\nThe lantern on the side table next is still " +
        "burning.\n\nYou grab it and head to the window to inspect the sound " +
        "that came from outside.\n\nIt is really foggy out and you can't see " +
        "past twenty yards.\n\nYou contemplate to yourself,\n\n'What could " +
        "possibly making these noises at this time of night?'" +
        "\n\nAn animal? Maybe it was just the wind. Was it a robber...");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("You hear a ruffle of leaves coming from just past " +
        "your yard. \n\nYou quickly head downstairs and look for something to " +
        "protect yourself with. \n\nYou look around and see a shovel.\n\nAs " +
        "you're about to head to the door you hear a loud yell from outside," +
        "\n\n\"Help, is anyone there?\" You suddenly freeze and chills run down " +
        "your spine.\n\nYou tiptoe to the door and peek outside.\n\nThe eyehole " +
        "reveals nothing but darkness. You're hesitant about what to do next.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("Against your consciousness, you decide to head " +
        "outside.\n\nThe door creeks loudly as you open it ever so slowly." +
        "\n\nYour lantern doesn't reveal any of the darnkness outside." +
        "\n\n\"Is anyone out there? I have a shovel and I'm not afraid to use " +
        "it\",\n\nyou yell out to the darkness. There is no response." +
        "\n\nYou stand there for a few minutes, flinching at every sound " +
        "around you.\n\nAll of a sudden there is a rush of footsteps through " +
        "the leaves towards you.\n\n\"Stop right there and show yourself!\", " +
        "you yell out to the darkness.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("\"Hello? I mean no harm.\", a voice from the " +
        "darkness responds.\n\nA figure appears a few yards in front of you." +
        "\n\nThey have their hands up and appear as frightened as you are." +
        "\n\n\"Approach slowly!\", you yell out to the stranger.\n\nThe " +
        "stranger slows their pace. There is a long silence as they " +
        "approach you.\n\nAs the figure becomes more visible your jaw drops." +
        "\n\nThe stranger appears to be glowing. To your amazement they seem " +
        "to be hovering.\n\nThey seem to be a foot or two of the ground." +
        "\n\nYou can tell the stranger can see your amazement.\n\n\"There is " +
        "nothing to be afraid of.\", the strange figure assures.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("\"Who are you and why are you on my land!\", you " +
        "stammer out to the figure.\n\nYou're still pointing your knife at " +
        "the stranger, afraid of any sudden movement.\n\n\"There's no need " +
        "for that.\", the stranger gestures at your knife.\n\n\"You " +
        "couldn't even use it even if you wanted to.\", the stranger " +
        "continues.\n\nNot knowing to trust the stranger, you slowly lower " +
        "your knife.\n\n\"My name is Odalf and I've been looking for someone " +
        "to help me.\",\n\nOdalf responds to your earlier question.\n\n\"I've " +
        "been searching all night in search of someone." +
        "\n\nIt appears that I have gotten myself into a predicament\", " +
        "Odalf explains.\n\n\"Based off your reaction to seeing me, you can " +
        "tell that I'm a ghost.\"");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("You gasp in shock. The floating figure does " +
        "appear to be a ghost.\n\n\"Sorry for my manners, but I never asked " +
        "for your name.\n\nWhat is your name my friend?\", " +
        "asks the ghost.");
      Console.WriteLine("\n\n" + line);
      mainCharacter.Name = UI.PromptLine("(Please enter in your name) ");
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("\"My name is " + mainCharacter.Name + ".\", you " +
      "respond slowly.\n\n\"How is it exactly that you are a ghost?\", you ask " +
        "Odalf.\n\n\"Funny that you would ask that question.\", Odalf says " +
        "chuckling to himself.\n\n\"I appear to have gotten myself into some " +
        "trouble.\n\nI was on an adventure and I mistakengly met my fate." +
        "\n\nBut it appears that not all hope is lost.\n\nI think that if I'm " +
        "able to get back to my body\n\nI can get out of this ghastly form.\"," +
        "\n\nexpalins Odalf.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("\"What kind of adventure were you on?\", you ask " +
        "Odalf.\n\nThere's a cavern in the woods not too far from here.\n\nIn " +
        "it lies a treasure bigger than either you or I can imagine.\", " +
        "Odalf explains.\n\n\"And you " + mainCharacter.Name + ", are going to " +
        "help me get the treasure!\",\n\nOdalf explains with excitement. " +
        "\n\n\"Me?! There is no way I'm going to this dangerous cavern.\n\nI " +
        "don't even know what's there. You died and that's all I need to " +
        "know!\",\n\nyou shout at Odalf.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("\"Well that's easy, I can tell you what's in the " +
        "caverns.\n\nThere's goblins and trolls and bears and a dragon " +
        "and-\",\n\nOdalf explains as you interupt him.\n\n\"A DRAGON!!!\", " +
        "you yell out.\n\n\"There is absolutely no way I'm going to help " +
        "you out.\", you shout out at Odalf.\n\nYou turn to leave and start " +
        "heading back to your house.\n\n\"Please! If you don't help me I may " +
        "never get back to my body!\", Odalf pleads.\n\n\"I would like to " +
        "help you, but I don't know how I'm any help.\",\n\nyou explain to " +
        "Odalf.\n\n\"I don't know how to fight and there is no way I would " +
        "be able to survive.\",\n\n\"That part is simple, I can teach " +
        "you!\", Odalf exlaims.");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();

      Console.WriteLine(line + "\n\n");
      Console.WriteLine("Lets start out by showing you how to fight an " +
        "enemy. Look at that Spider over there. \n\nWhen you walk up to it " +
        "it will attempt to attack you. You will be given four options: " + 
        "attack, use swap, and run. \n\n Lets give it a shot!");
      Console.WriteLine("\n\n" + line);
      TextUtil.PressAnyKeyBufferClear();
      return mainCharacter;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mainCharacter">Player</param>
    public static void PlayerPrompt(Player mainCharacter)
    {
      string[] files = new string[] { "Intro_0.txt", "Intro_1.txt" };
      string[] messages = new string[] { 
        string.Format("Congratulationss on Defeating your first Enemy {0}!", 
                      mainCharacter.Name), 
        string.Format("\"Are you ready to go?\" Odalf asks.") } ;
      TextUtil.PressAnyKeyBufferClear(messages[0]);
      TextUtil.PrintTextFile(files[0]);
      TextUtil.PressAnyKeyBufferClear(messages[1]);
      TextUtil.PressAnyKeyNOBufferClear(TextUtil.ReturnTextFile(files[1]));
    }

    /// <summary>
    /// Decides Ghost's reponse text
    /// </summary>
    /// <param name="playerInput">
    /// 1 for player agrees to go, 
    /// player disagrees otherwise
    /// </param>
    public static void ChoiceResponse(int playerInput)
    {
      if (playerInput == 1)
      {
        TextUtil.PressAnyKeyBufferClear("Good to hear, let's go.\n\n");
        return;
      }
      TextUtil.PressAnyKeyBufferClear("You're coming anyways... we're " +
                                      "walking into the tunnel.\n\n");
    }
    #endregion Public Methods

    #region Private Methods

    private static string CreateLine()
    {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < 79; i++)
      {
        builder.Append("-");
      }

      return builder.ToString();
    }
    #endregion Private Methods
  }
}
