namespace ExampleIOP;
public class DataBase
{
    private readonly IConnection connection;
    public DataBase(IConnection connection)
    {

        this.connection = connection;

    }
    public void OpenConnection()
    {
        connection.Open();
    }
    public void CloseConnection()
    {
        connection.Close();
    }
}
