Console.WriteLine("Variant 1. This program finds out, if entered number is even.");

while (true)
{
    Console.WriteLine("Enter a number: ");
    
    bool success = int.TryParse(Console.ReadLine(), out int number);

    if (success)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"Number {number} is even.");
        }
        else
        {
            Console.WriteLine($"Number {number} is not even.");
        }
    }
    else
    {
        Console.WriteLine("The value is not integer!");
    }

    success = false;
    while (!success)
    {
        Console.WriteLine("\nDo you want to continue? (Enter the number) \n(1) continue \n(0) end");
        success = int.TryParse(Console.ReadLine(), out number);
        if (number < 0 || number > 1)
            success = false;
        if (!success)
        {
            Console.WriteLine("The value is incorrect! Try again.");
        }
    }

    switch(number)
    {
        case 1:
            break;
        case 0:
            return;
        default:
            return;
    }
}