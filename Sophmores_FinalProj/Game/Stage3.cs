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
          case 8:
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
    /// Stage 3 Over Plot
    /// </summary>
    public static void Stage3Beat()
    {
      TextUtil.PrintTextFile(stage1Texts[21]);
      string msg = "The iron gates begin to lift up and you stumble out of " +
                   "the chamber, hoping never to return.";
      TextUtil.PressAnyKeyBufferClear(msg);
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
