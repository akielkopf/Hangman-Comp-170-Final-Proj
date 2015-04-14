using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroCS;

namespace Sophmores_FinalProj
{
  public class Combat
  {
    public bool playerTurn { get; private set; }
    public int turn { get; private set; }
    Random random = new Random();
    public void StartCombat(Player player, Enemy enemy)
    {
      Console.WriteLine("A Wild {0} has appeared!!", enemy.name);
      turn = 0;
      while (player.isAlive() && enemy.isAlive())
      {
        playerAction(player, enemy);
        enemyAttack(player, enemy);
        turn++;
      }
    }

    private void enemyAttack(Player player, Enemy enemy)
    {
      player.ModifyCurrentHP(-1 * random.Next(enemy.MinDamage,enemy.MaxDamage));
    }
    private void playerAttack(Player player, Enemy enemy)
    {
      enemy.ModifyCurrentHP(-1 * player.totalDamage);
    }
    private void playerAction(Player player, Enemy enemy)
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
              break;
            }

          }
        }
      } while (playerTurn == true);
    }

    public int playerInput(string inp)
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
    public string inp() 
    {
      string prompt = ("Make your choice...\n1) Attack  2)Swap  3) Use  4)Run");
      string playerInput = UI.PromptLine(prompt).Trim().ToLower();
      return playerInput;
    }
  }
}
