using System;
class Calculations
{
    public void add()
    {
        int num1, sum = 0;
        Console.WriteLine("\tEnter the series of number you want addition of...");
        Console.WriteLine("\tEnter the 0 to stop input and get result...");
        do
        {

            Console.Write("\t\tEnter the number:");
            num1 = int.Parse(Console.ReadLine());
            sum += num1;
        }
        while (num1 != 0);

        Console.WriteLine("\t Output --> The Sum of Above Entered Numbers is: " + sum);

    }

    public void subtract()
    {
        int num2, sub = 0;
        Console.WriteLine("\tEnter the series of number you want substraction of...");
        Console.WriteLine("\tEnter the 0 to stop input and get result...");
        do
        {
            Console.Write("\t\tEnter the number:");
            num2 = int.Parse(Console.ReadLine());
            if (num2 > 0 && sub == 0)
            {
                sub += num2;
            }
            else if ((num2 > 0) && (sub != 0))
            {
                sub -= num2;

            }
            else if ((num2 < 0) && (sub == 0))
            {
                sub += num2;
            }
            else if ((num2 < 0) && (sub < 0))
            {
                sub += num2;
            }
            else if ((num2 < 0) && (sub > 0))
            {
                sub -= num2;
            }
            else
            {
                break;
            }

        }
        while (num2 != 0);

        Console.WriteLine("\t Output --> The Substraction result of Above Entered Numbers is: " + sub);

    }

    public void multiply()
    {
        int num3, mul = 1;
        Console.WriteLine("\tEnter the series of number you want multiplication of...");
        Console.WriteLine("\tEnter the 1 to stop input and get result...");
        do
        {
            Console.Write("\t\tEnter the number:");
            num3 = int.Parse(Console.ReadLine());
            mul *= num3;
        }
        while (num3 != 1);


        Console.WriteLine("\t Output --> The Substraction result of Above Entered Numbers is: " + mul);

    }

    public void divide()
    {
        int num4, div = 1;
        Console.WriteLine("\tEnter the series of number you want division of...");
        Console.WriteLine("\tEnter the 1 to stop input and get result...");
        do
        {
            Console.Write("\t\tEnter the number:");
            num4 = int.Parse(Console.ReadLine());
            div /= num4;
        }
        while (num4 != 1);


        Console.WriteLine("\t Output --> The Division result of Above Entered Numbers is: " + div);

    }


}