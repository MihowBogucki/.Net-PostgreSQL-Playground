namespace repository;

using Npgsql;

public static class Car
{
    public static void Seed(NpgsqlConnection npgsqlConnection)
    {
        var cars = new Dictionary<string, int> { { "BMW", 36000 }, { "Audi", 52642 }, { "Mercedes", 57127 } };

        foreach (var (name, price) in cars)
        {
            Insert(npgsqlConnection, name, price);
        }
    }
    
    private static void Insert(NpgsqlConnection npgsqlConnection, string name, int price)
    {
        const string insertIntoCarsNamePriceValuesNamePrice = "INSERT INTO cars(name, price) VALUES(@name, @price)";
        using var npgsqlCommand = new NpgsqlCommand(insertIntoCarsNamePriceValuesNamePrice, npgsqlConnection);

        npgsqlCommand.Parameters.AddWithValue("name", name);
        npgsqlCommand.Parameters.AddWithValue("price", price);
        npgsqlCommand.Prepare();

        npgsqlCommand.ExecuteNonQuery();

        Console.WriteLine($"row inserted - name:{name}, value:{price}");
    }
}