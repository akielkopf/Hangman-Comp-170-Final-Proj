using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  interface IWeapon
  {
    bool PlayerCanEquip();
    void AddToInventory();
    void RemoveFromInventory();

  }
}
