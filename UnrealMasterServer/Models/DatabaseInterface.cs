using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace UnrealMasterServer.Models
{
    public class DatabaseInterface
    {
        private MySqlConnection sqlConnection;

        public DatabaseInterface()
        {
            IGNOREME ignore = new IGNOREME();
            string pwd = ignore.Password;
            string connectionString = "server=127.0.0.1 ; uid=ArKeid0s; pwd=" + pwd + ";database=projectv_data";

            sqlConnection = new MySqlConnection(connectionString);
        }

        public int PostData(ServerData data)
        {
            try
            {
                sqlConnection.Open();

                // Launch the procedure called AddServerEntry setup in MySql
                MySqlCommand command = new MySqlCommand("AddServerEntry", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                Random random = new Random();
                int serverId = random.Next(1, 2000000000);

                command.Parameters.AddWithValue("_ServerId", serverId);
                command.Parameters.AddWithValue("_IpAddress", data.IpAddress);
                command.Parameters.AddWithValue("_ServerName", data.ServerName);
                command.Parameters.AddWithValue("_MapName", data.MapName);
                command.Parameters.AddWithValue("_CurrentPlayers", data.CurrentPlayers);
                command.Parameters.AddWithValue("_MaxPlayers", data.MaxPlayers);

                command.ExecuteNonQuery();
                sqlConnection.Close();

                return 999;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

    }
}