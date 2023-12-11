using static System.Console;


// Initial Variables
bool proceed        = true;
Random random       = new Random();
int energyAmount    = random.Next(0, 101);





// Main Logic
WriteLine("");
WriteLine("Welcome to SimpleLifeSimulator");
WriteLine("##############################");
WriteLine("Created by LexInnHome");
WriteLine("");
WriteLine($"You spawn with {energyAmount} points of energy");

while (proceed)
{
    int procedure = AskTheUser();

    switch(procedure)
    {
        case (int)UserState.Eating:
            Eat();
            EnergyCheck();
            break;
        case (int)UserState.Working:
            GoToWork();
            EnergyCheck();
            break;
        case (int)UserState.Sleeping:
            Sleep();
            EnergyCheck();
            break;
        case (int)UserState.FuckingIt:
            WriteLine("Yeah, you better take a break! CU!");
            proceed = false;
            break;
    }
}
// End of Main Logic





// Functions Used
// -------------------------------------------
int Eat()
{
    WriteLine("...eating...");
    WriteLine("...press ENTER once done...");
    ReadLine();
    int refill = random.Next(10, 21);
    energyAmount += refill;
    WriteLine($"You ate and gained {refill} energy points.");
    WriteLine("");
    return energyAmount;
}
// -------------------------------------------

int Sleep()
{
    WriteLine("...sleeping...");
    WriteLine("...press ENTER once done...");
    ReadLine();
    int refill = random.Next(20, 81);
    energyAmount += refill;
    WriteLine($"You slept and gained {refill} energy points.");
    WriteLine("");
    return energyAmount;
}
// -------------------------------------------

int GoToWork()
{
    WriteLine("...working...");
    WriteLine("...press ENTER once done...");
    ReadLine();
    int consume = random.Next(10, 51);
    energyAmount -= consume;
    WriteLine($"You've lost {consume} energy points doing your job.");
    WriteLine();
    return energyAmount;
}
// -------------------------------------------

int AskTheUser()
{
    WriteLine("What do you do today?");
    WriteLine("1 - Eat\n2 - Go to work\n3 - Go back to sleep\n4 - F@ck it!");
    string? userCommand = ReadLine();
    while (userCommand == "")
    {
        WriteLine("Missing a command. Try again...");
        WriteLine("");
        WriteLine("What do you do next?");
        WriteLine("1 - Eat\n2 - Go to work\n3 - Go back to sleep\n4 - F@ck it!");
        userCommand = ReadLine();
    }
    return Int32.Parse(userCommand!) - 1;
}
// -------------------------------------------

bool EnergyCheck()
{
    if (energyAmount >= 100)
    {
        WriteLine($"Oh hey, you hadsome devil! What an abso-F@CKING-lutely lovely day, innit? You have {energyAmount} energy.");
        proceed = true;
        return proceed;
    }
    else if (energyAmount > 80)
    {
        WriteLine($"Life's goon, ain't gonna lie. Your energy is {energyAmount}. Pretty damn great, huh?");
        proceed = true;
        return proceed;
    }
    else if (energyAmount > 50)
    {
        WriteLine($"Uh, here we go again... You have {energyAmount} energy points");
        proceed = true;
        return proceed;
    }
    else if (energyAmount > 30)
    {
        WriteLine($"You feel like sh#t with {energyAmount} energy");
        proceed = true;
        return proceed;
    }
    else if (energyAmount > 10)
    {
        WriteLine($"F@ck! Life sucks! You have {energyAmount} energy. Almost dead :\\");
        proceed = true;
        return proceed;
    }
    else if (energyAmount > 0)
    {
        WriteLine($"You have {energyAmount} energy. You're two feet in the grave already, pal!");
        proceed = true;
        return proceed;
    }
    else if (energyAmount <= 0)
    {
        WriteLine("Dead. May be next time...");
        proceed = false;
        return proceed;
    }
    else
        return false;
}
// -------------------------------------------

enum UserState
{
    Eating,
    Working,
    Sleeping,
    FuckingIt
}