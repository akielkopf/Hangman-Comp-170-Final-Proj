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
			Console.WriteLine("A Wild {0} has appeared!! It appears to have {1}HP", enemy.name, enemy.totalHP);
      while (player.isAlive() && enemy.isAlive())
      {
        playerAction(player, enemy);
        if (!(enemy.isAlive()))
        {
          Console.WriteLine(enemy.name + " has fallen!");
          player.currentHP = player.totalHP;
          return;
        }
        enemyAttack(player, enemy);
        if (!(player.isAlive()))
        {
          Console.WriteLine(player.name + "has blacked out...");
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
      Console.WriteLine("{0} Health: {1}", player.name, player.currentHP);
    }
    private static void playerAttack(Player player, Enemy enemy)
    {
      Console.WriteLine("Enemy Health: {0}", enemy.currentHP);
      Console.WriteLine("Player attacks for {0} damage!", player.totalDamage);
      enemy.ModifyCurrentHP(-1 * player.totalDamage);
      Console.WriteLine("Enemy Health: {0}", enemy.currentHP);
    }
    private static void playerAction(Player player, Enemy enemy)
    {
      playerTurn = true;
      do
      {
        int curInput = playerInput(inp());
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
            if (item.Key.name == choice)
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
            if (item.Key.name == choice)
            {
              if (item.Key is HealthPotion)
                player.UseHealthPotion();
                playerTurn = false;
                break;
            }

          }
        }
        if (curInput == 0)
        {
          Console.WriteLine("Invalid Response, please enter either a number or the command name.");
        }
      } while (playerTurn == true);
    }

    public static int playerInput(string inp)
    {
      if      (inp == "attack" || inp == "1") { return 1; }
      else if (inp == "swap"   || inp == "2") { return 2; }
      else if (inp == "use"    || inp == "3") { return 3; }
      else if (inp == "run"    || inp == "4") { return 0; }
      else
        return 0;
    }

    //inp() and playerInput are temporary, I made them just to build combat system. We will mess with these once we start building the 
    // main game/method.
    public static string inp() 
    {
      Console.WriteLine("Make your choice...");
      string prompt = ("1) Attack  2)Swap  3) Use  4)Run");
      string playerInput = UI.PromptLine(prompt + "\n");
      return playerInput.Trim().ToLower();
    }
  }
}
