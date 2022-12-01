public class details
{
    public string name;
    public string adress;
    internal byte age;
    private long contact_no;

    public long phone()
    {
        contact_no = 9849451903;
        return contact_no;

    }

    public void detail(string name, string address, byte age, long phone)
    {
        Console.WriteLine($"I am {name}.\nI am from {address}.\nI am {age} old.\nMy contact number is {phone}.");
    }
}