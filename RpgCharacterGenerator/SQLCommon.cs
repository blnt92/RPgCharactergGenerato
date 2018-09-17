using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
 CREATE TABLE `character_properties` (
  `character_id` int(11) NOT NULL,
  `property_value_id` int(11) NOT NULL,
  PRIMARY KEY (`character_id`,`property_value_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `characters` (
  `character_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `created_by` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `creadet` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`character_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `property_types` (
  `prop_type_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `prop_type_name` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `prop_type_value_type` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`prop_type_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `property_value` (
  `prop_value_id` int(11) NOT NULL AUTO_INCREMENT,
  `prop_type_id` int(11) NOT NULL,
  `prop_value` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`prop_value_id`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

*/


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
