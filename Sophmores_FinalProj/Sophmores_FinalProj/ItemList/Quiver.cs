using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sophmores_FinalProj
{
  public class Quiver : Item
  {
    public int capacity { get; set; }
    public bool[] arrowSlots { get; private set; }
    public Quiver(string QuiverName, string QuiverType, 
                  string QuiverDescription, int QuiverCapacity)
      : base(QuiverName, QuiverType, QuiverDescription)
    {
      capacity = QuiverCapacity;
      arrowSlots = new bool[capacity];
      playerCanEquip = true;
    }
    public Quiver()
    {
      name = "Simple Quiver";
      type = "Quiver";
      capacity = 8;
      arrowSlots = new bool[capacity];
      playerCanEquip = true;
    }
    /// <summary>
    /// Add the specified amount arrows to the specified quiver
    /// </summary>
    /// <param name="item">Quiver to Add to</param>
    /// <param name="AmountOfArrowsToAdd">Number of arrows to Add</param>

    public void Add(Item item, int AmountOfArrowsToAdd)
    {
      int startToAdd = 0;
      for (int i = 0; i < arrowSlots.Length; i++)
      {
        if (arrowSlots[i] == false)
        {
          startToAdd = i;
          break;
        }
      }
      if (AmountOfArrowsToAdd <= (capacity - startToAdd))
      {
        int currentAdd = startToAdd;
        for (int i = 0; i < AmountOfArrowsToAdd; i++)
        {
          arrowSlots[currentAdd] = true;
          currentAdd++;
        }
      }
      else
      {
        Console.WriteLine("Cannot add that many {0}'s to {1}. {1} is not big " +
                          "enough", item.name, this.name);
      }
    }
    /// <summary>
    /// Remove the amount of specified arrows from the specified quiver
    /// </summary>
    /// <param name="item">Quiver to Remove from</param>
    /// <param name="AmountOfArrowsToRemove">Number of arrows to Remove</param>
    public void Remove(Item item, int AmountOfArrowsToRemove)
    {
      if (AmountOfArrowsToRemove <= (ArrowsInQuiver()))
      {
        arrowSlots.Reverse();
        int startToRemove = 0;
        for (int i = 0; i < arrowSlots.Length; i++)
        {
          if (i == (arrowSlots.Length - 1) && arrowSlots[i] == false)
          {
              Console.WriteLine("You don't have any of those");
          }
          else if (arrowSlots[i])
          {
            startToRemove = i;
            break;
          }
        }
        for (int i = 0; i < AmountOfArrowsToRemove; i++)
        {
          arrowSlots[i] = false;
        }
        arrowSlots.Reverse();
      }
      else
      {
        for (int i = 0; i < arrowSlots.Length; i++)
        {
          arrowSlots[i] = false;
        }
        Console.WriteLine(name + " is now empty...");
      }
    }
    /// <summary>
    /// Get Amount of Arrows in the Quiver
    /// </summary>
    /// <returns>Number of arrows as int</returns>
    public int ArrowsInQuiver()
    {
      int amountofArrows = 0;
      foreach (bool arrowCheck in arrowSlots)
      {
        if(arrowCheck)
        {
          amountofArrows++;
        }
      }
      Console.WriteLine(amountofArrows);
      return amountofArrows;
    }
  }
}
