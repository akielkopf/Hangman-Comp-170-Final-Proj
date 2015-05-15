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
  public static class Stage1
  {
    static string[] stage1Texts;
    /// <summary>
    /// Provides plot text for intro section of stage 1
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
    /// Provides plot and player interaction for second scene in stage 1
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
            TextUtil.PressAnyKeyNOBufferClear("");
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
    /// Provides Logic for the KERDASH puzzle
    /// </summary>
    private static void PrintLetterPuzzle()
    {            
      TextUtil.PressAnyKeyNOBufferClear("I wonder what could it be, maybe I " + 
                                        "shoould try a different combination");
      bool done = false;
      ConsoleKeyInfo info = new ConsoleKeyInfo();
      bool[] letterCheck = new bool[7];
      char[] letters = new char[] { 'k', 'e', 'r', 'd', 'a', 's', 'h' } ;
      string[] KERDASH = new string[7];
      for (int j = 0; j < KERDASH.Length; j++ )
      {
        // Gets all file locations of letters
        KERDASH[j] = TextUtil.ReturnTextFileLocation(letters[j] + "Letter.txt");
      }
      while (!done)
      {
        bool changed = false;
        info = Console.ReadKey(true);
        for (int i = 0; i < letters.Length; i++ )
        {
          if (info.KeyChar == letters[i])
          {
            letterCheck[i] = true;        // Tracks pressed letters
            changed = true;
          }
        }
        if (changed)
        {
          StringBuilder letterBuilder = new StringBuilder();
          StreamReader[] fileReaders = new StreamReader[7];
          for (int j = 0; j < KERDASH.Length; j++)
          {
            fileReaders[j] = new StreamReader(KERDASH[j]);
          }
          // Checks each letter that is true
          // And prints only the ones that are true 
          // In the correct order that they are in
          for (int j = 0; j < letters.Length; j++)
          {
            for (int k = 0; k < letterCheck.Length; k++)
            {            
              if (letterCheck[k])
              {
                letterBuilder.Append(fileReaders[k].ReadLine());
              }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(letterBuilder.ToString());
            letterBuilder.Clear();
          }
        }
        else
        {
          ConsoleColor temp = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Nothing seems to Happen...\n");
          Console.ForegroundColor = temp;
        }
        foreach (bool a in letterCheck)  // Loop exit check
        {
          done = true;
          if (!a)
          {
            done = false;
            break;
          }
        }
      }
      Console.Clear();
      TextUtil.PrintTextFile("KERDASH.txt");
      Console.ResetColor();
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
    /// Provides Plot text for End of Stage 1
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
            TextUtil.PressAnyKeyNOBufferClear("");
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
