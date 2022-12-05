class menu
{
    public void main_menu()
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("\t\tMAIN MENU");
        Console.WriteLine("\tEnter 1 for C# Looping Statements...");
        Console.WriteLine("\tEnter 2 for C# SelectionStatements...");
        Console.WriteLine("\tEnter 3 to view Assignment 1...");
        Console.WriteLine("\tEnter 0 to exit!!!");
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Enter Your Choice: ");
    }

    public void loop_menu()
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("\t\tLOOPS MENU");
        Console.WriteLine("\tEnter A to view about for loops...");
        Console.WriteLine("\tEnter B to view while loops");
        Console.WriteLine("\tEnter C to view do...while loops");
        Console.WriteLine("\tEnter O to return back to main menu!!!");
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Enter Your Choice: ");
    }

    public void SelectionStatement_Menu()
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("\t\tSELECTION STATEMENT MENU");
        Console.WriteLine("\tEnter A to view about if-else statement...");
        Console.WriteLine("\tEnter B to view if-else-if statement");
        Console.WriteLine("\tEnter C to view switch statement");
        Console.WriteLine("\tEnter O to return back to main menu!!!");
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Enter Your Choice: ");
    }
}