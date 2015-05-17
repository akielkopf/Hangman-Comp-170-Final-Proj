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
  /// Holds all the Logic for Stage 3
  /// </summary>
  public static class Stage3
  {
    /// <summary>
    /// Text files displayed to player as plot
    /// </summary>
    static string[] stage3Texts;
    /// <summary>
    /// Provides plot text for intro section of stage 3
    /// </summary>
    public static void Scene1()
    {
      string note = ("note 3.txt");
      string msg = string.Empty;
      stage3Texts = GetNarrationFiles();
      for (int i = 1; i < 7; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage3Texts[i]);
        switch (i)
        {
          case 1:
            string door = TextUtil.ReturnTextFile("LargeDoor.txt");
            TextUtil.PressAnyKeyNOBufferClear(door);
            msg = "You make your way onwards.";
            break;
          case 2:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "For as far as you can see ahead of you snow coats the " + 
              "ground and walls.";
            break;
          case 3:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "You pull the corpses hood over its face to spare you from " +
              "seeing anymore.";
            break;
          case 4:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Who is he? You sit there and ponder but nothing comes to " + 
              "mind.";
            TextUtil.PressAnyKeyNOBufferClear(TextUtil.ReturnTextFile(note));
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
      string msg = string.Empty;
      stage3Texts = GetNarrationFiles();
      for (int i = 7; i < 10; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage3Texts[i]);
        switch (i)
        {
          case 7:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "The lighting seems to dim ahead of you.";
            break;
          case 9:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Suddenly, a green figure is in front of you. A zombie!";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Provides plot and player interaction for third scene in stage 3
    /// </summary>
    public static void Scene3()
    {
      string msg = string.Empty;
      stage3Texts = GetNarrationFiles();
      for (int i = 10; i < 18; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage3Texts[i]);
        switch (i)
        {
          case 10:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "  There is no way of telling which way direction is " + 
              "forward, and which is the\ndirection you just came from.";
            break;
          case 11:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "You sheath you're weapon once more.";
            break;
          case 14:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TextUtil.PrintTextFile("nohelpforyou.txt");
            Console.ResetColor();
            msg = "In the corner are more skeletal remains.";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Gets the individual narrated files from directory
    /// </summary>
    /// <returns>Files as strings in array</returns>
    private static string[] GetNarrationFiles()
    {
      List<string> stage1Texts = new List<string>();
      for (int i = 0; i < 25; i++)
      {
        string file = ("Stage3_" + i + ".txt");
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
      stage3Texts = GetNarrationFiles();
      for (int i = 18; i < 25; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage3Texts[i]);
        switch (i)
        {
          case 24:
            msg = ("There is a brief silence and Odalf blurts, " +
              "\"Lets get on to the last door then!\"");
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// First prompt for Stage 3
    /// </summary>
    public static void PreDoorMsg()
    {
      TextUtil.PressAnyKeyBufferClear(TextUtil.ReturnTextFile("Stage3_0.txt"));
    }
  }
}
