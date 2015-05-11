using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Sophmores_FinalProj.Utilities;

namespace Sophmores_FinalProj
{
  /// <summary>
  /// Holds all the Logic for Stage 1
  /// </summary>
  private static class Stage3 //change to public before utilization
  {
    static string[] stage1Texts;
    /// <summary>
    /// Provides plot text for intro section of stage 3
    /// </summary>
    public static void Scene1()
    {
      string msg = string.Empty;
      stage1Texts = GetNarrationFiles();
      for (int i = 1; i < 8; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage1Texts[i]);
        switch (i)
        {
          case 0:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Anxiety over what lies ahead fills your mind.";
            break;
          case 2:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "You take a close look and conclude it is blood.";
            break;
          case 3:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "\"I’ll need a bow for these. Though there’s little  harm " +
                  "in holding on to \nthem for now.\" you contemplate.";
            break;
          case 5:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "No response.";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Provides plot and player interaction for second scene in stage 3
    /// </summary>
    public static void Scene2()
    {
      string note = ("Note_Foreshadow.txt");
      string msg = string.Empty;
      stage1Texts = GetNarrationFiles();
      for (int i = 8; i < 14; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage1Texts[i]);
        switch (i)
        {
          case 9:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Just then your eyes catch something on the wall.";
            break;
          case 10:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Well Odalf did say I might want to note things.";
            break;
          case 12:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TextUtil.PressAnyKeyNOBufferClear(TextUtil.ReturnTextFile(note));
            Console.ResetColor();
            msg = "You look for more of the paper but there doesn’t seem to " +
              "be any.";
            break;
          case 13:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = ("Gargh abash glar rah tuu!”, yells the creature. " +
                   "It’s a goblin!");
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Plot for Boss encounter
    /// </summary>
    public static void BossScene()
    {
      string msg = string.Empty;
      stage1Texts = GetNarrationFiles();
      for (int i = 15; i < 24; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage1Texts[i]);
        switch (i)
        {
          case 16:
            PrintLetterPuzzle();
            break;
          case 19:
            string chest = "goldChest.txt";
            TextUtil.PrintTextFile(chest);
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Stage 1 Over Plot
    /// </summary>
    public static void Stage3Beat()
    {
      TextUtil.PrintTextFile(stage1Texts[21]);
      string msg = "The iron gates begin to lift up and you stumble out of " +
                   "the chamber, hoping never to return.";
      TextUtil.PressAnyKeyBufferClear(msg);
    }
    /// <summary>
    /// Provides plot and player interaction for first scene in stage 3
    /// </summary>
    public static void BreakWebsScene()
    {
      string msg = string.Empty;
      stage1Texts = GetNarrationFiles();
      for (int i = 5; i < 11; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage1Texts[i]);
        switch (i)
        {
          case 5:
            msg = "\"I think I'll need this as well.\", you think to yourself.";
            break;
          case 7:
            msg = "That's when you notice you are surrounded by insects....";
            break;
          case 8:
            msg = "As you begin to take it all in, you can help but see the " +
                  "spider webs...";
            break;
          case 11:
            msg = "What should you do?";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
      string question = "Try your Sword? Or your Wand? \n 1)Sword \n 2)Wand";
      int answer = Program.getChoice(2, question);
      bool pass = false;
      while (pass != true)
      {
        if (answer == 1)
        {
          Console.WriteLine("The Sword gets tangled up in the webs! " +
                             "It's no use!");
          Console.WriteLine();
          answer = Program.getChoice(2, "maybe try a different weapon. " +
                                "\n 1)Sword \n 2)Wand");
        }
        else if (answer == 2)
        {
          Console.WriteLine("The spider's web lose's it's eerie glow and " +
                            "crumbles");
          Console.WriteLine();
          pass = true;
        }
      }
      msg = "A Giant Spider!!";
      TextUtil.PrintTextFile(stage1Texts[12]);
      TextUtil.PressAnyKeyBufferClear(msg);
    }
    /// <summary>
    /// Prints note plot and creates note item displayed
    /// </summary>
    /// <returns>Note Item</returns>
    public static Item PlayerViewsNote()
    {
      string noteDescription = TextUtil.ReturnTextFile("stage2note.txt");
      Item note = new Item("StarNote", "Paper", noteDescription);
      Console.WriteLine(note.description);
      TextUtil.PrintTextFile("Stage2_4.txt");
      return note;
    }
    /// <summary>
    /// Provides Plot text for End of stage1/begining of stage 3
    /// </summary>
    public static void PrintPreDoorMsg()
    {
      stage1Texts = GetNarrationFiles();
      Console.Clear();
      TextUtil.PrintTextFile(stage1Texts[0]);
      TextUtil.PressAnyKeyBufferClear();
    }
    /// <summary>
    /// Gets the individual narrated files from directory
    /// </summary>
    /// <returns>Files as strings in array</returns>
    private static string[] GetNarrationFiles()
    {
      List<string> stage1Texts = new List<string>();
      for (int i = 0; i < 26; i++)
      {
        string file = ("Stage1_" + i + ".txt");
        stage1Texts.Add(file);
      }
      return stage1Texts.ToArray();
    }
    /// <summary>
    /// Provides Plot text for End of Stage 3
    /// </summary>
    public static void BossIsDeadScene()
    {
      string msg = string.Empty;
      stage1Texts = GetNarrationFiles();
      for (int i = 24; i < 26; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage1Texts[i]);
        switch (i)
        {
          case 25:
            msg = "So that’s where that lead.";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
  }
}
