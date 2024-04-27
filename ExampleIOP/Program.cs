
using ExampleIOP;

var mySqlConn = new MySqlConnection();
var sqlServerConn = new SqlServerConnection();

var dataBase = new DataBase(mySqlConn);

dataBase.OpenConnection();
dataBase.CloseConnection();

var dataBase2 = new DataBase(sqlServerConn);

dataBase2.OpenConnection();
dataBase2.CloseConnection();


