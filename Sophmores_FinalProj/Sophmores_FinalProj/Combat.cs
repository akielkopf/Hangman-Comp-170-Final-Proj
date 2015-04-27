using IntroCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophmores_FinalProj
{
  public static class Combat
  {
    #region Private Fields

    private static bool playerTurn = false;
    private static int poisonStart;
    private static Random random = new Random();
    private static int turn;

    #endregion Private Fields

    #region Public Methods

    public static string message(Item cur)
    {
      if (cur is Poison)
      {
        string mess = " has poisoned the enemy with " + cur.name + " for three turns.";
        return mess;
      }
      else if (cur is HealthPotion)
      {
        string mess = " has used " + cur.name + " to recover HP.";
        return mess;
      }
      else
      {
        return "";
      }
    }

    public static void StartCombat(Player player, Enemy enemy)
    {
      turn = 0;
      poisonStart = -4;
      Console.WriteLine("A Wild {0} has appeared!! It appears to have {1}HP.", enemy.Name, enemy.TotalHP);
      while (player.isAlive() && enemy.isAlive())
      {
        playerAction(player, enemy, turn);
        if (!(enemy.isAlive()))
        {
          Console.WriteLine(enemy.Name + " has fallen!");
          starLine();
          player.CurrentHP = player.TotalHP;
          break;
        }
        enemyAttack(player, enemy);
        if (!(player.isAlive()))
        {
          Console.WriteLine(player.Name + "has blacked out...");
          starLine();
          break;
        }
        turn++;
        depoison(player);
      }
      endFight(player);
      return;
    }

    #endregion Public Methods

    #region Private Methods

    /// <summary>
    /// Checks if it has been 4 turns since the player used poison, if so it disables
    /// </summary>
    /// <param name="player"></param>
    private static void depoison(Player player)
    {
      if (turn == poisonStart + 4)
      {
        player.RemoveBuff();
        Console.WriteLine("The poison on the enemy has worn off!");
      }
    }

    /// <summary>
    /// returns values back to default after fight ends
    /// </summary>
    /// <param name="player"></param>
    private static void endFight(Player player)
    {
      turn = 0;
      poisonStart = -4;
      player.RemoveBuff();
    }

    private static void enemyAttack(Player player, Enemy enemy)
    {
      int attack = random.Next(enemy.MinDamage, enemy.MaxDamage);
      Console.WriteLine("Enemy attacks for {0} damage!", attack);
      player.ModifyCurrentHP(-1 * attack);
      Console.WriteLine("{0} Health: {1} \n", player.Name, player.CurrentHP);
    }

    /// <summary>
    /// cleaner way to get choices.
    /// </summary>
    /// <param name="numChoices"> number of choices the user should have. </param>
    /// <returns></returns>
    private static int getChoice(int numChoices)
    {
      int choice = UI.PromptInt("Please enter a choice number: ");
      while (choice < 1 || choice > numChoices)
      {
        Console.WriteLine("{0} is not a valid choice!", choice);
        choice = UI.PromptInt("Please enter a valid choice number: ");
      }
      return choice;
    }

    /// <summary>
    /// Displays user-side combat options and retrieves string input answer
    /// </summary>
    /// <returns></returns>
    private static string inp()
    {
      starLine();
      Console.WriteLine("Make your choice...");
      string prompt = ("1) Attack  2)Swap  3) Use  4)Run");
      string playerInput = UI.PromptLine(prompt + "\n");
      return playerInput.Trim().ToLower();
    }

    /// <summary>
    /// Player side turn logic.
    /// </summary>
    /// <param name="player"></param>
    /// <param name="enemy"></param>
    /// <param name="current turn"></param>
    private static void playerAction(Player player, Enemy enemy, int turn)
    {
      playerTurn = true;
      while (playerTurn == true)
      {
        int curInput = preCombatCheck(player);
        if (curInput == 1)
        {
          playerAttack(player, enemy);
          playerTurn = false;
          break;
        }
        if (curInput == 2)
        {
          List<Item> curWeapons = player.DisplayAllWeaponsReturnList();

          int choice = getChoice(curWeapons.Count + 1);
          if (choice - 1 < curWeapons.Count)
          {
            if ((curWeapons[choice - 1]).playerCanEquip)
            {
              player.UnEquip();
              player.Equip(curWeapons[choice - 1] as Weapon);
              Console.WriteLine("Player has equipped " + curWeapons[choice - 1].name + ".");
              playerTurn = false;
              break;
            }
            else
            {
              Console.WriteLine("You can't Equip that!");
            }
          }
          else
          {
            Console.WriteLine("You have chosen to keep your current weapon equipped.");
          }
        }
        if (curInput == 3)
        {
          List<Item> curCItems = player.DisplayConsumablesReturnList();

          int choice = getChoice(curCItems.Count + 1);
          if (choice - 1 < curCItems.Count)
          {
            if (curCItems[choice - 1] is Poison) { poisonStart = turn; }
            player.ConsumeItem(curCItems[choice - 1]);
            Console.WriteLine(player.Name + message(curCItems[choice - 1]));
            playerTurn = false;
            break;
          }
          else { Console.WriteLine("No item used."); }
        }
        if (curInput == 4)
        {
          if (player.TutorialComplete == false)
          {
            Console.WriteLine("You can't run, this is your first fight!");
            playerTurn = false;
            break;
          }
          int chance = random.Next(100);
          if (chance <= 70)
          {
            Console.WriteLine("You have escaped from the enemy!");
            //add code to end fight
          }
          else
          {
            Console.WriteLine("The enemy saw it coming this time, you were not able to escape!");
            playerTurn = false;
            break;
          }
        }
      }
    }
    /// <summary>
    /// Player attacks enemy for player.TotalDamage
    /// IF Enemy Affinity does cause Enemy to be immune
    /// </summary>
    private static void playerAttack(Player player, Enemy enemy)
    {
      string enemyAffinity = enemy.Affinity.ToLower().Trim();
      string playerWeaponType = (enemyAffinity == "n") ? "n" : player.EquippedWeapon.type.ToLower().Trim();
      if (playerWeaponType != enemyAffinity)
      {
        Console.WriteLine("The enemy seems to be unaffected by this weapon type!");
        Console.WriteLine("Enemy Health: {0} \n", enemy.CurrentHP);
        return;
      }
      Console.WriteLine("Enemy Health: {0}", enemy.CurrentHP);
      Console.WriteLine("{0} attacks for {1} damage!", player.Name, player.TotalDamage);
      enemy.ModifyCurrentHP(-1 * player.TotalDamage);
      Console.WriteLine("Enemy Health: {0} \n", enemy.CurrentHP);
    }

    /// <summary>
    /// Turns string input into number input
    /// </summary>
    private static int playerInput(string inp)
    {
      if      (inp == "attack" || inp == "1") { return 1; }
      else if (inp == "swap"   || inp == "2") { return 2; }
      else if (inp == "use"    || inp == "3") { return 3; }
      else if (inp == "run"    || inp == "4") { return 4; }
      else
        return 0;
    }

    /// <summary>
    /// Checks various parameters and locks options that player should not have
    /// access to.
    /// </summary>
    private static int preCombatCheck(Player player)
    {
      int curInput = playerInput(inp());
      bool validInp = false;
      while (validInp == false)
      {
        if (curInput == 1)
        {
          validInp = true;
          break;
        }
        if (curInput == 2 || curInput == 3)
        {
          if (player.inventory.contents.Count > 0)
          {
            validInp = true;
            break;
          }
          else
          {
            Console.WriteLine("You fool! You have no Items in your inventory!");
            curInput = playerInput(inp());
          }
        }
        if (curInput == 4 && player.TutorialComplete == false)
        {
          Console.WriteLine("You can't run, this is your first fight!");
          curInput = playerInput(inp());
        }
        if (curInput == 4 && player.TutorialComplete == true)
        {
          validInp = true;
          break;
        }
        if (curInput == 0)
        {
          Console.WriteLine("You've entered an invalid command");
          curInput = playerInput(inp());
        }
      }
      return curInput;
    }

    /// <summary>
    /// Prints a line of stars
    /// </summary>
    private static void starLine()
    {
      Console.WriteLine();
      for (int i = 0; i < 65; i++) { Console.Write("*"); }
      Console.WriteLine("*");
    }

    #endregion Private Methods
  }
}
