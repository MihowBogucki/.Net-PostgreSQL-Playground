// See https://aka.ms/new-console-template for more information

using Npgsql;

Console.WriteLine("Hello, Postgres!");

var cs = "Host=localhost:5433;Username=root;Password=password;Database=postgres";

using var con = new NpgsqlConnection(cs);
con.Open();

var sql = "SELECT version()";

using var cmd = new NpgsqlCommand(sql, con);

var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"PostgreSQL version: {version}");

