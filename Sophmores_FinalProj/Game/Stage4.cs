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
  /// Holds all the Logic for Stage 4
  /// </summary>
  public static class Stage4
  {
    static string[] stage4Texts;
    /// <summary>
    /// Provides plot text for intro section of stage 4
    /// </summary>
    public static void Scene1()
    {
      string msg = string.Empty;
      stage4Texts = GetNarrationFiles();
      for (int i = 0; i < 10; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage4Texts[i]);
        switch (i)
        {
          case 2:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "\"Follow me and watch your step.\" Odalf lets out as he " +
              "leads the way.";
            break;
          case 3:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "  At every couple steps that you take you send rocks over " +
              "edge, into the burning abyss.";
            break;
          case 6:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Rocks from the ceiling fall as the screech echoes on.";
            break;
          case 7:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "He lets out another screech and lets out a breath of fire.";
            break;
          case 8:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "Odalf...";
            break;
          default:
            msg = null;
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    /// <summary>
    /// Provides plot and player interaction for second scene in stage 4
    /// </summary>
    public static void Scene2()
    {
      string msg = string.Empty;
      stage4Texts = GetNarrationFiles();
      for (int i = 10; i < 14; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stage4Texts[i]);
        switch (i)
        {
          case 10:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "\"Actually, it's all mine,\" sounds a voice to your rear.";
            break;
          case 11:
            TextUtil.PressAnyKeyNOBufferClear("");
            msg = "He's lost his ethereal glow, but his icy blue eyes glow " +
              "with newfound power.";
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
      List<string> stage4Texts = new List<string>();
      for (int i = 0; i < 15; i++)
      {
        string file = ("Stage4_" + i + ".txt");
        stage4Texts.Add(file);
      }
      return stage4Texts.ToArray();
    }
    /// <summary>
    /// Provides Plot text for End of Stage 4
    /// </summary>
    public static void BossIsDeadScene()
    {
      Console.Clear();
      stage4Texts = GetNarrationFiles();
      TextUtil.PrintTextFile(stage4Texts[14]);
      TextUtil.PressAnyKeyNOBufferClear("");
      string msg = "It's time to go home....";
      TextUtil.PressAnyKeyBufferClear(msg);
    }
  }
}
