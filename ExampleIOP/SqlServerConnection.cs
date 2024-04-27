namespace ExampleIOP;
public class SqlServerConnection : IConnection
{
    public void Open()
    {
        Console.WriteLine("Opened Sql Server connection.");
    }

    public void Close()
    {
        Console.WriteLine("Closed Sql Server connection.");
    }
}
