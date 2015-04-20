using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroCS;

namespace Sophmores_FinalProj.Utilities
{
  /// <summary>
  /// Holds Utility code for manipulating the console window
  /// </summary>
  public class TextUtil
  {
    /// <summary>
    /// Prints standard Press Any Key to Continue Message
    /// Then clears the screen
    /// </summary>
    public static void PressAnyKeyBufferClear()
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
    public static void PressAnyKeyBufferClear(string message)
    {
      Console.WriteLine("\n" + message);
      Console.ReadKey();
      Console.Clear();
    }
    /// <summary>
    /// Sets Buffer Size (within the console that is in the output)
    /// </summary>
    public static void SetBufferSize()
    {
      if (CheckOS())
      {
      Console.BufferHeight = (Int16.MaxValue - 1);
      Console.BufferWidth = (80);
      }
    }
    /// <summary>
    /// Checks user OS platform
    /// </summary>
    /// <returns>True if Windows, false otherwise</returns>
    private static bool CheckOS()
    {
      OperatingSystem os = Environment.OSVersion;
      string platform = os.Platform.ToString();
      if (platform.ToLower().StartsWith("w"))
      {
        return true;
      }
      return false;
    }
    /// <summary>
    /// Prints to Console contents of the supplied text file
    /// *Throws NotSupportedException* if param is not a '.txt'
    /// </summary>
    /// <param name="textFileToRead">
    /// The text file to be read and printed
    /// </param>
    public static void PrintTextFile(string textFileToRead)
    {
			string txt = ".txt";
			if (textFileToRead.EndsWith (txt)) {
				StringBuilder builder = new StringBuilder ();
				var reader = FIO.OpenReader (FIO.GetLocation (textFileToRead),
					textFileToRead);
				while (!(reader.EndOfStream)) {

					builder.Append("\n"+reader.ReadLine ());
				}
				string text = ("" + builder);
				Console.WriteLine (text);
				reader.Close ();
			} else {
				string msg = "That is not a text file!";
				Console.WriteLine (msg);
				throw new NotSupportedException (msg);
			}    
		}
    /// <summary>
    /// Prints to Console the contents of the supplied text
    /// File AND Returns file contents as String
    /// *Throws NotSupportedException* if param is not a '.txt'
    /// </summary>
    /// <param name="textFileToRead">
    /// The text file to be read, printed, and returned
    /// </param>
    /// <returns>Contents of the text file as String</returns>
    public static string PrintAndReturnTextFile(string textFileToRead)
    {
			string txt = ".txt";
			if (textFileToRead.EndsWith (txt)) {
				StringBuilder builder = new StringBuilder ();
				var reader = FIO.OpenReader (FIO.GetLocation (textFileToRead),
					textFileToRead);
				while (!(reader.EndOfStream)) {

					builder.Append("\n"+reader.ReadLine ());
				}
				string text = ("" + builder);
				Console.WriteLine (text);
				reader.Close ();
				return text;
			} else {
				string msg = "That is not a text file!";
				Console.WriteLine (msg);
				throw new NotSupportedException (msg);
			}
    }
	/// <summary>
	/// Returns the text file.
	/// </summary>
	/// <returns>The text file.</returns>
	/// <param name="textFileToRead">Text file to read.</param>
	public static string ReturnTextFile(string textFileToRead)
		{
			string txt = ".txt";
			if (textFileToRead.EndsWith (txt)) {
				StringBuilder builder = new StringBuilder ();
				var reader = FIO.OpenReader (FIO.GetLocation (textFileToRead),
					            textFileToRead);
				while (!(reader.EndOfStream)) {
				
					builder.Append("\n"+reader.ReadLine ());
				}
				string text = ("" + builder);
				reader.Close ();
				return text;
			} else {
				string msg = "That is not a text file!";
				Console.WriteLine (msg);
				throw new NotSupportedException (msg);
			}
		}
  	}
}
