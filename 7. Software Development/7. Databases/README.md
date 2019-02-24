# Свързване на приложения с бази от данни

## MySQL
```
// Connection String and SQL Query
var connstr = "server=localhost;database=minions;port=3306;user=root;password=root";
var sql = "SELECT Villains.Name, EvilnessFactors.Name FROM Villains LEFT JOIN EvilnessFactors ON EvilnessFactors.Id = Villains.EvilnessFactorId";

// 1. Connection
MySqlConnection connection = new MySqlConnection(connstr);
conn.Open();

// 2. Command
MySqlCommand command = new MySqlCommand(sql, connection);

// 3. Reader
MySqlDataReader reader = command.ExecuteReader();
while (reader.Read()) Console.WriteLine("Villain: {0}, EvilnessFactor: {1}", reader[0], reader[1]);

reader.Close();
connection.Close();
```