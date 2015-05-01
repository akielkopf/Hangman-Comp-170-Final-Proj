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
    public static void PrintMsgs()
    {
      string[] stageTexts = GetNarrationFiles();
    }

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
