using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public class HealthPotion : Item
  {
    /// <summary>
    /// Health Potions restore health and are consumable 
    /// </summary>
    public int Potency { get; set; }
    /// <summary>
    /// Creates a custom Health Potion which
    /// restores currentHP and are consumable
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="description">Potion Description</param>
    /// <param name="potency">Amount of HP to restore</param>
    public HealthPotion(string name,string description, int potency) 
      : base (name, "Potion", description, true)
    {
      Potency = potency;
      playerCanEquip = false;
	  consumable = true;
    }
    public HealthPotion(HealthPotion potion)
    {
      name = potion.name;
      type = "Potion";
      description = potion.description;
      playerCanEquip = false;
      consumable = true;
      Potency = potion.Potency;
    }
    /// <summary>
    /// Creates a Basic Health Potion that restores 10HP
    /// </summary>
    public HealthPotion()
    {
      name = "Basic Health Potion";
      type = "Potion";
      description = "A Basic Health Potion that restores 10 Health";
      playerCanEquip = false;
      consumable = true;
      Potency = 10;
    }
  }
}
