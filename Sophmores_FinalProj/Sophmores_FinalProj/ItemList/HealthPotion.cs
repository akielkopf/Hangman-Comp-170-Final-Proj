
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
        /// <param name="super">if true, creates super poison. If false, creates basic poison.</param>
        public HealthPotion(string name, string description, bool super)
            : base(name, "Potion", description, true)
        {
            if (!super)
            {
                this.description = description + "\n effect: restores 20 HP";
                Potency = 20;
            }
            else if (super)
            {
                this.description = description + "\n effect: restores all HP";
                Potency = 100;
            }
            playerCanEquip = false;
        }
        /// <summary>
        /// creates basic health potion that restores 20 HP
        /// </summary>
        public HealthPotion()
        {
            name = "Basic Health Potion";
            type = "Potion";
            description = "Restores 20 HP";
            playerCanEquip = false;
            consumable = true;
            Potency = 20;
        }
        /// <summary>
        /// returns potency of potion
        /// </summary>
        /// <param name="potion">potion who's potency will be checked</param>
        /// <returns></returns>
        public int getPotency(HealthPotion potion)
        {
            return potion.Potency;
        }
    }
}
