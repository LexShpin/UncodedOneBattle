using UncodedOneBattle.Enums;

namespace UncodedOneBattle;

public class Battle
{
  public Party Heroes { get; }
  public Party Monsters { get; }

  public Battle(Party heroes, Party monsters)
  {
    Heroes = heroes;
    Monsters = monsters;
  }

  public void Run()
  {
    foreach (Party party in new[] { Heroes, Monsters })
    {
      // if (party.PlayerInCharge == PlayerType.Computer)
      
      foreach (Character character in party.Characters)
      {
        Console.WriteLine();
        Console.WriteLine($"{character.Name} is taking a turn...");
        character.TakeTurn(ActionType.DoNothing);
        Thread.Sleep(500);
      }
    }
  }
}