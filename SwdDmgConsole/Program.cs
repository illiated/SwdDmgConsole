using SwdDmgConsole;

Random random = new Random();

SwdDmg swdDmg = new SwdDmg(RollDice());

while (true)
{

}

int RollDice()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}