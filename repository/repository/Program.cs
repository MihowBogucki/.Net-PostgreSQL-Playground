// See https://aka.ms/new-console-template for more information

using Npgsql;
using repository;

Console.WriteLine("Hello, Postgres!");

const string cs = "Host=localhost:5433;Username=root;Password=password;Database=postgres";

using var con = new NpgsqlConnection(cs);
con.Open();

Car.Seed(con);