class EntryPoint
{
    public static void Main()
    {
        //Console.WriteLine("Nepal is beautiful country");
        // Console.Write("Enter Your Name: ");
        // string x = Console.ReadLine();
        // Console.WriteLine("Your Name is: " + x);

        //Conditionals, Selection statements
        // If-else, if-elseif-else, switch
        // Branching

        // short age = 23;
        // Console.Write("Enter Your Age: ");
        // short age = Convert.ToInt16(Console.ReadLine());
        // if (age > 18) // comparison operators >, <, <=, >=, !=, ==, &&, ||
        // {
        //     Console.WriteLine("You are old. hahaha");
        // }
        // else
        // {
        //     Console.WriteLine("You're still a kid. hahaha.");
        // }

        // Console.Write("Enter Your Age: ");
        // short age = Convert.ToInt16(Console.ReadLine());
        // if (age < 18) // comparison operators >, <, <=, >=, !=, ==, &&, ||
        // {
        //     Console.WriteLine("You are child.");
        // }
        // else if (age < 40)
        // {
        //     Console.WriteLine("You're adult.");
        // }
        // else if (age < 60)
        // {
        //     Console.WriteLine("You are in your middle age.");
        // }
        // else
        // {
        //     Console.WriteLine("You are old. Hahahaha");
        // }

        Console.Write("Enter your rashi: ");
        string rashi = Console.ReadLine();
        if (rashi == "Mesh")
        {
            Console.WriteLine("Mesh rashi initials are ka, kha...");
        }
        else if (rashi == "Tula")
        {
            Console.WriteLine("Tula rashi initials are Ga, Gha...");
        }
        else
        {
            Console.WriteLine("Brisha rashi initials are Ba, Bi...");
        }

        switch (rashi)
        {
            case "Mesh":
                Console.WriteLine("Mesh rashi initials are ka, kha...");
                break;
            case "Tula":
                Console.WriteLine("Tula rashi initials are Ga, Gha...");
                break;
            case "Brisha":
                ("Brisha rashi initials are Ba, Bi...");
                break;
            default:
                Console.WriteLine("Unknown rashi");
                break;
        }
    }
}