namespace ExampleIOP;

public class MySqlConnection : IConnection
{
    public void Open()
    {
        Console.WriteLine("Opened MySql connection.");
    }

    public void Close()
    {
        Console.WriteLine("Closed MySql connection.");
    }    
}
