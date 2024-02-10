

using UncodedOneBattle;
using UncodedOneBattle.Enums;

TrueProgrammer player = SetPlayer();

Party heroes = new Party();
heroes.Characters.Add(player);
heroes.PlayerInCharge = PlayerType.Computer;

Party monsters = new Party();
monsters.Characters.Add(new Skeleton());
monsters.PlayerInCharge = PlayerType.Computer;

Battle battle = new Battle(heroes, monsters);


battle.Run();


TrueProgrammer SetPlayer()
{
  Console.Write("What's your name? ");
  string? userName = Console.ReadLine();

  return new TrueProgrammer(userName);
}