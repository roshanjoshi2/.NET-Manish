class Loops
{
    public void while_loop()
    {

        // While - use case
        string key = "y";
        Console.WriteLine("Nepal will be printed until you press other key than 'y'");
        while (key == "y")
        {
            Console.WriteLine("Nepal");
            key = Console.ReadLine();
        }
        return;
    }

    public void for_loop()
    {
        //CW - Print all number less than 500 which are multiple of 3 and 5
        Console.WriteLine("OUTPUT---> Numbers divisible by 3 and 5 less than 500 are as follows: ");
        for (int i = 0; i < 500; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        return;
    }



    public void do_while()
    {
        int num;
        int sum = 0;
        Console.WriteLine("Enter the series of number to add on.\nEntering 0 will return the sum of all entered numbers.");
        do
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            sum += num;

        }
        while (num != 0);

        Console.WriteLine("OUTPUT---> Sum of Above Entered Numbers is: " + sum);
        return;
    }

    public void looping_body()
    {

        menu m = new();
        char cho = char.Parse(Console.ReadLine());
        while (cho != 'O')
        {

            switch (cho)
            {
                case 'A':
                    for_loop();
                    break;
                case 'B':
                    while_loop();
                    break;
                case 'C':
                    do_while();
                    break;
                case 'O':
                    break;
                default:
                    Console.WriteLine("Invalid Input...\nPlease provide valid input!!!");
                    break;
            }

            m.loop_menu();
            cho = char.Parse(Console.ReadLine());
        }
    }
}