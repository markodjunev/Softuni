﻿namespace Remove_Villain
{
    using System;
    using System.Data.SqlClient;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var villainId = int.Parse(Console.ReadLine());

            using (var connection = new SqlConnection(@"Server=PC-785\SQLEXPRESS05;Database=MinionsDB;Integrated Security=True"))
            {
                connection.Open();

                var villainName = GetVillainNameById(connection, villainId);

                if (villainName == null)
                {
                    Console.WriteLine("No such villain was found.");
                    Environment.Exit(0);
                }

                var releasedMinions = GetReleasedMinions(connection, villainId);
                DeleteVillainById(connection, villainId);

                Console.WriteLine($"{villainName} was deleted.");
                Console.WriteLine($"{releasedMinions} minions were released.");
            }
        }

        private static void DeleteVillainById(SqlConnection connection, int villainId)
        {
            using (var command = new SqlCommand(Queries.DeleteFromVillain, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);
                command.ExecuteNonQuery();
            }
        }

        private static int GetReleasedMinions(SqlConnection connection, int villainId)
        {
            using (var command = new SqlCommand(Queries.DeleteFromMappingTable, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);

                return command.ExecuteNonQuery();
            }
        }

        private static string GetVillainNameById(SqlConnection connection, int villainId)
        {
            using (var command = new SqlCommand(Queries.SelectVillainNameById, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);

                return (string)command.ExecuteScalar();
            }
        }

    }
}