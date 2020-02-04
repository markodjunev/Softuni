namespace Villain_Names
{
    using System;
    using System.Data.SqlClient;

    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                var selectQuery = "SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount " +
                    "FROM Villains AS v JOIN MinionsVillains AS mv ON v.Id = mv.Id " +
                    "GROUP BY v.Id, v.Name " +
                    "HAVING COUNT(mv.Id) > 3" +
                    "ORDER BY COUNT(mv.Id)";

                using (var command = new SqlCommand(selectQuery, connection))
                {
                    using (var dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine($"{dataReader[0]} - {dataReader[1]}");
                        }
                    }
                }
            }

        }
    }
}