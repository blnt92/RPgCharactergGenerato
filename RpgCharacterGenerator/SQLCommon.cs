using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RpgCharacterGenerator
{ 

    using ResultSet = List<Dictionary<string, string>>;

    class SQLCommon
    {
        private MySqlConnection DBCon;
        private MySqlCommand DBCommand;
        public MySqlDataReader LastRead;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        public Boolean Connect()
        {
            server = "localhost";
            database = "rpggenerator";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"+ "SslMode = none";

            DBCon = new MySqlConnection(connectionString);
            try
            {
                DBCon.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public ResultSet RunQuery(string QueryText)
        {
            if (Connect())
            {
                DBCommand = new MySqlCommand(QueryText, DBCon);
                LastRead  = DBCommand.ExecuteReader();
            }
            return ConvertQuery(LastRead);
        }

        public ResultSet ConvertQuery(MySqlDataReader Data)
        {
            ResultSet Result = new List<Dictionary<string, string>>();
            while(Data.Read())
            {
                Dictionary<string, string> Dict = new Dictionary<string, string>();
                for (int i = 0; i < Data.FieldCount; i++)
                {
                  Dict.Add(Data.GetName(i), Data.GetString(Data.GetName(i)));
                }
                Result.Add(Dict);
            }
            return Result;
        }
    }
}
