﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Sophmores_FinalProj.Utilities
{
  /// <summary>
  /// Inventories for characters, contain simple methods
  /// For adding and Removing Items
  /// </summary>
  public class Inventory : IEnumerable
  {
    #region Public Properties

    public Dictionary<Item, int> contents { get; private set; }
    /// <summary>
    /// Returns a new list with a list of items without their quantities
    /// </summary>
    public List<Item> itemList 
    { 
      get 
      {
        return new List<Item>(this.contents.Keys); 
      }
    }
    public int Count { get { return this.contents.Count; } }
    #endregion Public Properties

    #region Public Constructors
    /// <summary>
    /// Creates a new inventory
    /// </summary>
    public Inventory()
    {
      contents = new Dictionary<Item, int>();
    }

    /// <summary>
    /// Create new inventory from one that already exists 
    /// </summary>
    /// <param name="OldInventory"> Inventory to be copied from </param>
    public Inventory(Inventory OldInventory)
    {
      if (OldInventory != null)
      {
        contents = new Dictionary<Item, int>(OldInventory.contents);
      }
      else
      {
        contents = new Dictionary<Item, int>();
      }
    }

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    /// Add Item to inventory 
    /// </summary>
    /// <param name="item"> item </param>
    /// <param name="itemCount"> Number of the SAME item to add </param>
    public void Add(Item item, int itemCount)
    {
      if (contents.ContainsKey(item))
      {
        contents[item] += itemCount;
      }
      else
      {
        contents.Add(item, itemCount);
      }
    }

    /// <summary>
    /// Removes specified amount of Items 
    /// </summary>
    /// <param name="item"> Item </param>
    /// <param name="ItemCount"> Number of items to Remove </param>
    public void Remove(Item item, int itemCount)
    {
      if (contents.ContainsKey(item))
      {
        contents[item] -= itemCount;
        if (contents[item] <= 0)
        {
          contents.Remove(item);
          Console.WriteLine("You have used your last {0}...", item.name);
        }
      }
      else
      {
        Console.WriteLine("You're not carrying a {0}", item.name);
      }
    }

    #endregion Public Methods


    IEnumerator IEnumerable.GetEnumerator()
    {
      return contents.Keys.GetEnumerator();
    }
  }
}
