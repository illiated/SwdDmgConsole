using SwdDmgConsole;

Random random = new Random();

SwdDmg swdDmg = new SwdDmg(RollDice());

while (true)
{
    Console.WriteLine("Type '0' for normal, '1' for magic, '2' for flaming, '3' for magic/flaming, or any other key to quit.");
    char inputKey = Console.ReadKey(true).KeyChar;
    if (inputKey != '0' && inputKey != '1' && inputKey != '2' && inputKey != '3') return;
    swdDmg.Roll = RollDice();
    swdDmg.Magic = (inputKey == '1' || inputKey == '3');
    swdDmg.Flaming = (inputKey == '2' || inputKey == '3');

    Console.WriteLine($"\nRolled {swdDmg.Roll} for sword damage {swdDmg.Damage}.");
}

int RollDice()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}