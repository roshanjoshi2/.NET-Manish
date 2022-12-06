using System;
class EntryPoint
{
    public static void Main()
    {

        // menu m = new();
        // m.main_menu();
        // byte ch = byte.Parse(Console.ReadLine());

        // while (ch != 0)
        // {
        //     switch (ch)
        //     {
        //         case 1:
        //             Loops lp = new();
        //             m.loop_menu();
        //             lp.looping_body();
        //             break;
        //         case 2:
        //             Selection sel = new();
        //             m.SelectionStatement_Menu();
        //             sel.SelectionStatementsBody();
        //             break;
        //         case 3:
        //             assign1 a1 = new();
        //             a1.AssignObj1();
        //             a1.AssignObj2();
        //             break;
        //         case 0:
        //             break;
        //         default:
        //             Console.WriteLine("Invalid Input...\nPlease provide valid input!!!");
        //             break;


        //     }
        //     m.main_menu();
        //     ch = byte.Parse(Console.ReadLine());
        // }


        // byte age = 23;
        // string name = "Ram";
        // string m = $"{name} is {age} years old"; // String Interpolation
        // Console.WriteLine(m);

        Method m = new();
        m.Print();
        m.Print("I am Manish and I am god!!!");
        m.GetMessage();
        m.GetCovidResult("No");
        var sum = m.AddS(23.5, 24.5);

    }
}