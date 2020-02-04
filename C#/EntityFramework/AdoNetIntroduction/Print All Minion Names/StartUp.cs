namespace Print_All_Minion_Names
{
    using System;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Server=PC-785\SQLEXPRESS05;Database=MinionsDB;Integrated Security=True"))
            {
                connection.Open();

                var minionNames = GetAllMinionNames(connection);

                PrintAllMinionNames(minionNames);
            }
        }

        private static void PrintAllMinionNames(List<string> minionNames)
        {
            if (minionNames.Count > 0)
            {
                for (int i = 0; i < minionNames.Count / 2; i++)
                {
                    Console.WriteLine(minionNames[i]);
                    Console.WriteLine(minionNames[minionNames.Count - 1 - i]);
                }

                if (minionNames.Count % 2 != 0)
                {
                    Console.WriteLine(minionNames[minionNames.Count / 2]);
                }
            }
        }

        private static List<string> GetAllMinionNames(SqlConnection connection)
        {
            var minionNames = new List<string>();
            var selectNameQuery = "SELECT Name FROM Minions";

            using (var command = new SqlCommand(selectNameQuery, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var name = (string)dataReader[0];

                        minionNames.Add(name);
                    }
                }
            }

            return minionNames;
        }
    }
}