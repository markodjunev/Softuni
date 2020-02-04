namespace Increase_Minion_Age
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    class StartUp
    {
        public static void Main(string[] args)
        {
            var minionIds = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            using (var connection = new SqlConnection(@"Server=PC-785\SQLEXPRESS05;Database=MinionsDB;Integrated Security=True"))
            {
                connection.Open();

                foreach (var id in minionIds)
                {
                    UpdateMinionsById(connection, id);
                }

                PrintAllMinions(connection);
            }
        }

        private static void PrintAllMinions(SqlConnection connection)
        {
            using (var command = new SqlCommand(Queries.SelectNameAndAge, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var minionName = (string)dataReader[0];
                        var minionAge = (int)dataReader[1];

                        Console.WriteLine($"{minionName} {minionAge}");
                    }
                }
            }
        }

        private static void UpdateMinionsById(SqlConnection connection, int id)
        {
            using (var command = new SqlCommand(Queries.UpdateMinionById, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
