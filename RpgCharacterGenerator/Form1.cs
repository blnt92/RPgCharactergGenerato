using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RpgCharacterGenerator
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLCommon db = new SQLCommon();

            MySqlDataReader sql = db.RunQuery("select * from property_value");

            while (sql.Read())
            {
                richTextBox1.AppendText(sql.GetString("prop_value") + "\n");
            }
        }
    }
}
