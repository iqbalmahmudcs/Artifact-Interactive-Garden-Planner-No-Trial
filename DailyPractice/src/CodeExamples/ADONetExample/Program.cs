using ADONetExample;
var connectionString = "Server=OFFICER-IT-DHAK\\SQLEXPRESS;Database=CSharpB19;User Id=csharpb19;Password=asdf1234Z@; Trust Server Certificate=True";
DataUtility dataUtility = new DataUtility(connectionString);

//Insert Data
var name = Console.ReadLine();
var fees = Console.ReadLine();
var date = Console.ReadLine();
var activeStatus = Console.ReadLine();

var sql = $"insert into Courses(Name, Fees, ClassStartDate, IsActive) values(@name, @fees, @date, @activeStatus)";
//var sql = "delete from Courses where ID = 100";
var parameters = new Dictionary<string, object>
{
    { "name", name},
    { "fees", fees},
    { "date", date},
    { "activeStatus", activeStatus}
};
dataUtility.ExecuteSql(sql, parameters);


////Read Data
//var sql1 = "select * from courses where fees >= 15000";
//var data = dataUtility.GetData(sql1);

//foreach(var item in data)
//{
//    foreach(var col in item)
//    {
//        Console.Write($"{col.Key} {col.Value}, ");
//    }
//    Console.WriteLine();
//}
