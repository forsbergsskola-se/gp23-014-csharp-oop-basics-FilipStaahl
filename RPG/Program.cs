
Player player = new Player();
player.Health = 3;
Monster monster = new Monster();
monster.Health = 3;

Console.WriteLine($@"You have: {player.Health} Health. 
You are fighting a monster with {monster.Health}.");

while (player.Health > 0)
{
    char userInput = GetUserInput();
    if (userInput == 'A')
    {
        player.Attack(monster);
    } 
    else if (userInput == 'H')
    {
        player.Heal();
    }
    // Monsters Turn
    if (monster.Health > 0)
    {
        monster.Attack(player);
    }
    else
    {
        monster = new Monster();
        monster.Health = 3;
        Console.WriteLine($"A new monster has spawned with {monster.Health} health.");
    }
}
Console.WriteLine("GAME OVER!");

char GetUserInput()
{
    Console.WriteLine("What do you want to do? [A]ttack or [H]eal?");
    var key = Console.ReadKey();
    Console.WriteLine();
    return char.ToUpper(key.KeyChar);
}