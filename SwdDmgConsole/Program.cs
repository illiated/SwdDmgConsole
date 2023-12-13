using SwdDmgConsole;

Random random = new Random();

SwdDmg swdDmg = new SwdDmg(RollDice());

while (true)
{
    Console.WriteLine("0 for normal, 1 for magic, 2 for flaming, 3 for magic/flaming, or any other key to quit.");
    char inputKey = Console.ReadKey(true).KeyChar;
    if (inputKey != '0' && inputKey != '1' && inputKey != '2' && inputKey != '3') return;
    //whats next for the app to do? type this here!

}

int RollDice()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}