using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sophmores_FinalProj.Utilities;

namespace Sophmores_FinalProj
{
  public static class Stage2
  {
    static string[] stageTexts;

    public static void PreNoteMsgs()
    {
      string msg = string.Empty;
      stageTexts = GetNarrationFiles();
      for (int i = 1; i < 4; i++)
      {
        Console.Clear();
        TextUtil.PrintTextFile(stageTexts[i]);
        switch (i)
        {
          case 1:
            msg = "Touching the cavern wall and you feel the wetness on " + 
                  "your hand...";
            break;
          case 2:
            msg = "You spot something on the ground up ahead but you can't " + 
              "quite make it out...";
              break;
          case 3:
            msg = "You reach towards the satchel...";
            break;
        }
        TextUtil.PressAnyKeyBufferClear(msg);
      }
    }
    public static void PrintPreDoorMsg()
    {
      stageTexts = GetNarrationFiles();
      Console.Clear();
      TextUtil.PrintTextFile(stageTexts[0]);
      TextUtil.PressAnyKeyBufferClear();
    }
    /// <summary>
    /// Gets the individual narrated files from directory
    /// </summary>
    /// <returns>Files as strings in array</returns>
    private static string[] GetNarrationFiles()
    {
      List<string> stageTexts = new List<string>();
      for (int i = 0; i < 22; i++)
      {
        string file = ("Stage2_" + i + ".txt");
        if (i == 15)
        {
          string jumpFile = ("Jump_Option_");
          file = jumpFile + file;
        }
        else if (i == 16)
        {
          string climbFile = ("ClimbDown_Option_");
          file = climbFile + file;
        }
        stageTexts.Add(file);
      }
      return stageTexts.ToArray();
    }
  }
}
