using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroCS;

namespace Sophmores_FinalProj
{
  public static class Combat
  {
    static bool playerTurn = false;
    static Random random = new Random();
    public static void StartCombat(Player player, Enemy enemy)
    {
      int turn = 0;
			Console.WriteLine("A Wild {0} has appeared!! It appears to have {1}HP", enemy.Name, enemy.TotalHP);fdfd
      while (player.isAlive() && enemy.isAlive())
      {
        playerAction(player, enemy);
        if (!(enemy.isAlive()))
        {
          Console.WriteLine(enemy.Name + " has fallen!");
          Console.WriteLine();
          for (int i = 0; i < 65; i++) { Console.Write("*"); }
          Console.WriteLine("*");
          player.CurrentHP = player.TotalHP;
          return;
        }
        enemyAttack(player, enemy);
        if (!(player.isAlive()))
        {
          Console.WriteLine(player.Name + "has blacked out...");
          Console.WriteLine();
          for (int i = 0; i < 65; i++) { Console.Write("*"); }
          Console.WriteLine("*");
          return;
        }
        turn++;
      }
      return;
    }

    private static void enemyAttack(Player player, Enemy enemy)
    {
      int attack = random.Next(enemy.MinDamage,enemy.MaxDamage);
      Console.WriteLine("Enemy attacks for {0} damage!", attack);
      player.ModifyCurrentHP(-1 * attack);
      Console.WriteLine("{0} Health: {1} \n", player.Name, player.CurrentHP);
    }
    private static void playerAttack(Player player, Enemy enemy) 
    {
      Console.WriteLine("Enemy Health: {0}", enemy.CurrentHP);
      Console.WriteLine("Player attacks for {0} damage!", player.TotalDamage);
      enemy.ModifyCurrentHP(-1 * player.TotalDamage);
      Console.WriteLine("Enemy Health: {0} \n", enemy.CurrentHP);
    }
    private static void playerAction(Player player, Enemy enemy)
    {
      playerTurn = true;
      do
      {
        int curInput = playerInput(inp());
        bool validInp = false;
        while (validInp == false) {
            if (curInput == 1) {
                validInp = true;
                break;
            }
            if (curInput == 2 || curInput == 3) {
                if (player.inventory.contents.Count > 0)
                {
                    validInp = true;
                    break;
                }
                else {
                    Console.WriteLine("You fool! You have no Items in your inventory!");
                    curInput = playerInput(inp());
                }
            }
            if (curInput == 4 && player.TutorialComplete == false) {
                Console.WriteLine("You can't run, this is your first fight!");
                curInput = playerInput(inp());
            }
            if (curInput == 4 && player.TutorialComplete == true) {
                validInp = true;
                break;
            }
            if (curInput == 0) {
                Console.WriteLine("You've entered an invalid command");
                curInput = playerInput(inp());
            }
            
        }
        if (curInput == 1)
        {
          playerAttack(player, enemy);
          playerTurn = false;
          break;
        }
        if (curInput == 2)
        {
          player.DisplayInventoryContents();

          string choice = UI.PromptLine("Make your choice...");
          foreach (KeyValuePair<Item, int> item in player.inventory.contents)
          {
            if (item.Key.name.ToLower() == choice.Trim().ToLower())
            {
              if (item.Key.playerCanEquip)
              {
                player.Equip(item.Key as Weapon);
                playerTurn = false;
                break;
                
              }
              else
              {
                Console.WriteLine("You can't Equip that!");
              }
            }
          }
        }
        if (curInput == 3)
        {
          player.DisplayConsumables();

          string choice = UI.PromptLine("Make your choice...");
          foreach (KeyValuePair<Item, int> item in player.inventory.contents)
          {
            if (item.Key.name.ToLower() == choice.Trim().ToLower())
            {
              if (item.Key is HealthPotion)
                player.UseHealthPotion();
                playerTurn = false;
                break;
            }

          }
        }
        if (curInput == 4) { 
            int chance = random.Next(100);
            if (chance <= 70)
            {
                Console.WriteLine("You have escaped from the enemy!");
                //add code to end fight
            }
            else {
                Console.WriteLine("The enemy saw it coming this time, you were not able to escape!");
                playerTurn = false;
                break;
            }
        }

        
      } while (playerTurn == true);
    }

    private static int playerInput(string inp)
    {
      if      (inp == "attack" || inp == "1") { return 1; }
      else if (inp == "swap"   || inp == "2") { return 2; }
      else if (inp == "use"    || inp == "3") { return 3; }
      else if (inp == "run"    || inp == "4") { return 4; }
      else
        return 0;
    }

    //inp() and playerInput are temporary, I made them just to build combat system. We will mess with these once we start building the 
    // main game/method.
    private static string inp() 
    {
      Console.WriteLine();
      for (int i = 0; i < 65; i++) { Console.Write("*"); }
      Console.WriteLine("*");
      Console.WriteLine("Make your choice...");
      string prompt = ("1) Attack  2)Swap  3) Use  4)Run");
      string playerInput = UI.PromptLine(prompt + "\n");      
      return playerInput.Trim().ToLower();
    }
  }
}
