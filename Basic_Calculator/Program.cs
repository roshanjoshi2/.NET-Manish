using System;
class Calculator
{
    public static void Main()
    {
        menu m = new();
        Calculations cal = new();

        m.main_menu();
        int choice = int.Parse(Console.ReadLine());

        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    cal.add();
                    break;
                case 2:
                    cal.subtract();
                    break;
                case 3:
                    cal.multiply();
                    break;
                case 4:
                    cal.divide();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("!!!-INVALID INPUT-!!!\nPlease Provide Valid Input...");
                    break;
            }

            m.main_menu();
            choice = int.Parse(Console.ReadLine());
        }

    }
}