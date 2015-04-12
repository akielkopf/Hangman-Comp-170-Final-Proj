using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  class Key : Item
  {
    /// <summary>
    /// Keys, type Key, are consumable
    /// </summary>
    public Key()
    {
      type = "Key";
      consumable = true;
    }
  }
}
