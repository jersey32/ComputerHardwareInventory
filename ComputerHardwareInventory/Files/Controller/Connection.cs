using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ComputerHardwareInventory.Files.Module
{
    class Connection
    {
        public MySqlConnection con;

        public Connection()
        {

            string host = "localhost";
            string db = "computer_hardware";
            string port = "3306";
            string user = "admin";
            string pass = "";
            string constring = "datasource= " + host + "; database=" + db + "; port=" + port + "; username=" + user + "; password=" + pass + "; SslMode=none";

        }
      class controlls : Connection
        {
            public void login_data()
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand)
                {
                    cmd.CommandText = "SELECT * FROM `login_tbl` WHERE `Username` AND `Password`";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                }
            }
        }
    }

}
