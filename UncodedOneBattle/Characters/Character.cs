using UncodedOneBattle.Enums;
using UncodedOneBattle.Interfaces;

namespace UncodedOneBattle;

public class Character : IAttack
{
  public string Name { get; set; }
  
  public Character() { }

  public Character(string name)
  {
    Name = name;
  }

  public void TakeTurn(ActionType actionType)
  {
    if (actionType == ActionType.DoNothing)
      Console.WriteLine($"{Name} did NOTHING.");
  }

  public void Attack(AttackType attackType)
  {
    
  }
}