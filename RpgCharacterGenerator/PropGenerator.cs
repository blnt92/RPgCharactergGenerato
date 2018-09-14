using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RpgCharacterGenerator
{
    using ResultSet = List<Dictionary<string, string>>;
    class PropGenerator
    {
        private SQLCommon DB;
        public Dictionary<string, string> FAllproperties;
        private ResultSet Properties;
        private ResultSet Values;

        public PropGenerator()
        {
            DB = new SQLCommon();
            Properties = DB.RunQuery("select * from property_types");
            Values = DB.RunQuery("select * from property_value");
            FAllproperties = new Dictionary<string, string>();
        }

        public void GetAllProperties()
        {  
             
            List<string> Vals = new List<string>();
            FAllproperties.Clear();

            for (int i = 0; i < Properties.Count; i++)
            {
                Vals.Clear();
                for (int y = 0; y < Values.Count; y++)
                {
                    if (Values[y]["prop_type_id"] == Properties[i]["prop_type_id"])
                    {
                        Vals.Add(Values[y]["prop_value"]);                   
                    }
                }

                if (Vals.Count > 0)
                {
                    Random rnd = new Random();
                    FAllproperties.Add(Properties[i]["prop_type_name"], Vals[rnd.Next(0, Vals.Count)]);
                }  
            }
        }
    }
}
