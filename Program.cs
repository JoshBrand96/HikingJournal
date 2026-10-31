bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("---Hiking and Exploration---");
    Console.WriteLine("Welcome to the Hiking and Exploration Program!");
    Console.WriteLine("""
    1. Add a new hike
    2. View hiking journal
    3. Search hikes
    4. Exit
    """);
    Console.WriteLine();
    Console.WriteLine("Please select an option (1-4):");

    string? menuChoice = Console.ReadLine();

    //Using string interpolation to implement the user's input into the output
    Console.WriteLine($"You entered: {menuChoice}");

    if (menuChoice == "1")
    {
        Console.WriteLine("Add a new hike selected!");
    }

    else if (menuChoice == "2")
    {
        Console.WriteLine("View hiking journal selected!");
    }

    else if (menuChoice == "3")
    {
        Console.WriteLine("Search hikes selected!");
    }

    else if (menuChoice == "4")
    {
        Console.WriteLine("Goodbye!");
        isRunning = false;
    }
    //Implementing some error handling in case a user inputs something invalid
    else
    {
        Console.WriteLine("Invalid Option");

    }
}