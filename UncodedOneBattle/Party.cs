using UncodedOneBattle.Enums;

namespace UncodedOneBattle;

public class Party
{
  public PlayerType PlayerInCharge { get; set; }
  
  public List<Character> Characters = new List<Character>();
}