class Method
{
    // Simplest possible: returns nothing, takes no arguments
    public void Print()
    {
        Console.WriteLine("This is example of non-returning, no arguments method");

    }

    // Returns nothing, takes arguments
    public void Print(string message) // Method Overloading
    {
        Console.WriteLine(message);

    }

    // Returns something, takes no arguments
    public string GetMessage()
    {
        var city = "Kavrepalanchowk";
        return city;
    }

    public bool GetCovidResult(string hasCold)
    {
        if (hasCold == "Yes")
        {
            Console.WriteLine("You have covid");
            return true;
        }
        else
        {
            return false;
        }

    }

    // Expression bodied members
    public double AddS(double a, double b) => a + b;

    // Takes arguements or not, returns multiple values

}