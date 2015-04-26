using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class Key : Item
  {
    #region Public Constructors

    /// <summary>
    /// Keys, type Key, are consumable 
    /// </summary>
    public Key()
    {
      type = "Key";
      consumable = true;
    }

    #endregion Public Constructors
  }
}