int swordCost = 25;

// Step 1: Ask player for name, remember it
Console.WriteLine("Traveller, what is your name?");
string playerName = Console.ReadLine();

// Step 2: Ask player for sum of held gold (currency)
Console.WriteLine("How much gold do you have with you?");
int playerGold = int.Parse( Console.ReadLine() );

// Step 3: tell player about sword
Console.WriteLine($"Fabulous. We are selling a bronze sword for {swordCost} gold.");

// Step4: buy item if able, deduct cost from gold
if (playerGold >= swordCost)
{
    playerGold -= swordCost;
    Console.WriteLine($"Thank you for you purchase! Remaining gold: {playerGold}");
}
else // if not the case
{
    Console.WriteLine($"{playerName}, you do not have enough gold!");
    Console.WriteLine($"The sword costs {swordCost}, you only have {playerGold} gold!");
}