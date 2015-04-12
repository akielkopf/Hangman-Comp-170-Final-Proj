using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  class Enemy : Character
  {
    /// <summary>
    /// Basic enemy Class, have Max and Min Damage values
    /// For random hit damage
    /// </summary>
    public string Affinity { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public double BuffMultiplier { get; set; }
    /// <summary>
    /// Default Enemy with 'n' Affinity, Damage 5-10
    /// </summary>
    public Enemy()
    {
      Affinity = "n";
      MinDamage = 5;
      MaxDamage = 10;
      BuffMultiplier = 1;
    }
    /// <summary>
    /// Enemy with user-set damage range
    /// </summary>
    /// <param name="minDamage">The lowest damage an enemy can do</param>
    /// <param name="maxDamage">The highest damage and enemy can do</param>
    public Enemy(int minDamage, int maxDamage)
    {
      Affinity = "n";
      MinDamage = minDamage;
      MaxDamage = maxDamage;
      BuffMultiplier = 1;
    }
    /// <summary>
    /// Enemy with user-set damage range, and affinity
    /// </summary>
    /// <param name="affinity">Enemy's Affinity</param>
    /// <param name="minDamage">The lowest damage an enemy can do</param>
    /// <param name="maxDamage">The highest damage and enemy can do</param>
    public Enemy(string affinity, int minDamage, int maxDamage)
    {
      Affinity = affinity;
      MinDamage = minDamage;
      MaxDamage = maxDamage;
      BuffMultiplier = 1;
    }    
    /// <summary>
    /// Enemy with user-set damage range, and affinity
    /// </summary>
    /// <param name="affinity">Enemy's Affinity</param>
    /// <param name="minDamage">The lowest damage an enemy can do</param>
    /// <param name="maxDamage">The highest damage and enemy can do</param>
    /// <param name="buffMultiplier">amount to multiply damage by</param>
    public Enemy(string affinity, int minDamage, int maxDamage, 
                 int buffMultiplier)
    {
      Affinity = affinity;
      MinDamage = minDamage;
      MaxDamage = maxDamage;
      BuffMultiplier = buffMultiplier;
    }
    /// <summary>
    /// Applies Specified value to Enemy BuffMultiplier
    /// </summary>
    /// <param name="buff">Value of new BuffMultiplier</param>
    public void ApplyBuffOrDebuff(double buff) 
    {
      BuffMultiplier = buff;
    }
    /// <summary>
    /// Resets BuffMultiplier to 1
    /// </summary>
    public void RemoveBuff()
    {
      BuffMultiplier = 1;
    }
  }
}
