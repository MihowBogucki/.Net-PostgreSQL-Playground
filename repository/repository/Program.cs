﻿// See https://aka.ms/new-console-template for more information

using Npgsql;
using repository;

Console.WriteLine("Hello, Postgres!");

const string cs = "Host=localhost:5434;Username=postgres;Password=postgres";

using var con = new NpgsqlConnection(cs);
con.Open();

Car.Seed(con);
