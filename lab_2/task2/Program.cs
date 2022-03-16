Console.WriteLine("Variant 5. This program finds out if a point is located in the shaded area.");
// x + y <= 8; x + y >= 3; x <= 0

Program:
while (true)
{
	Console.WriteLine("\nEnter the coordinates of point: ");
	int x_coord;
	int y_coord;

	bool success = int.TryParse(Console.ReadLine(), out x_coord);
	if (!success)
    {
		Console.WriteLine("The value is not correct! Try again.");
		goto Program;
    }

	success = int.TryParse(Console.ReadLine(), out y_coord);
	if (!success)
	{
		Console.WriteLine("The value is not correct! Try again.");
		goto Program;
	}

	if (x_coord > 0)
    {
		Console.WriteLine("The point is NOT in the area.");
    }
	else
    {
		if (Math.Abs(x_coord) + Math.Abs(y_coord) == 8 || Math.Abs(x_coord) + Math.Abs(y_coord) == 3)
        {
			Console.WriteLine("The point is ON THE BORDER of the area.");
        }
		else if (Math.Abs(x_coord) + Math.Abs(y_coord) < 8 && Math.Abs(x_coord) + Math.Abs(y_coord) > 3)
		{
			Console.WriteLine("The point is IN the area.");
		}
		else
        {
			Console.WriteLine("The point is NOT in the area.");
		}
	}

    success = false;
    int choice = 0;
    while (!success)
    {
        Console.WriteLine("\nDo you want to continue? (Enter the number) \n(1) continue \n(0) end");
        success = int.TryParse(Console.ReadLine(), out choice);
        if (choice < 0 || choice > 1)
            success = false;
        if (!success)
        {
            Console.WriteLine("The value is incorrect! Try again.");
        }
    }

    switch (choice)
    {
        case 1:
            break;
        case 0:
            return;
        default:
            return;
    }
}