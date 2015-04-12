using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
    public class Combat
    {
    //    public Player mc;
     //   public Character enemy;
        public int turn;
        public void Combat(Player mc, Character enemy)
        {
            turn = 0;
            while (mc.isAlive() && enemy.isAlive()) 
            {                
                playerAction(mc);
                enemyAttack(enemy);
                turn++;
            }
        }
        
        public void enemyAttack(Player mc, Character enemy)
        {
            mc.deltaHP(-1 * enemy.damageAbility);
        }
        public void playerAttack(Player mc, Character enemy)
        {
            enemy.deltaHP(-1 * mc.totalDamage);
        }
        public void playerAction(Player Mc, Character enemy)
        {
            bool playerTurn = true;
            while (playerTurn == true) 
            {
                int curInput = playerInput(inp());
                if (curInput == 1) 
                {
                    playerAttack(Mc, enemy);
                    playerTurn = false;
                    break;
                }
                if (curInput == 2)
                {
                    Inventory.displayWeapons(); //hasn't been made yet
                    
                    string choice = inp();
                    foreach (KeyValuePair<Item, int> foo in inv)
                    {
                        if (foo.Key.name == choice)
                        {
                            mc.Equip(foo.Key);
                            break;
                        }
                    }
                }
                if (curInput == 3)
                {
                    Inventory.displayConsumableItems(); //displayConsumableItems hasn't been made yet

                    string choice = inp();
                    foreach (KeyValuePair<Item, int> foo in inv)
                    {
                        if (foo.Key.name == choice)
                        {
                            mc.useItem(foo.Key); //useItem hasn't been made yet
                            break;
                        }
                    
                    }
                }
            }
        }

        public int playerInput(string inp)
        {
            inp = inp.Trim();
            if (inp == "attack") { return 1; }
            else if (inp == "swap") { return 2; }
            else if (inp == "use") { return 3; }
            else { return 0; }
        }

        //inp() and playerInput are temporary, I made them just to build combat system. We will mess with these once we start building the 
        // main game/method.
        public string inp() { return Console.ReadLine(); }
    }
}
