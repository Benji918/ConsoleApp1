Console.WriteLine("Give me a number");
string user_number = Console.ReadLine();
int num1 = 0;


if (int.TryParse(user_number, out num1))
{
    Console.WriteLine("You entered a number");
}
else
{
    Console.WriteLine("You didn\'t enter a number but a string bitvh");
}

Console.WriteLine($"User entered number + 1 {num1}");

Console.ReadKey();