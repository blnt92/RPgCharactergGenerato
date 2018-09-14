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

    using ResultSet = List<Dictionary<string, string>>;

    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropGenerator prop = new PropGenerator();
            prop.GetAllProperties();
            richTextBox1.Clear();
            richTextBox1.AppendText("Eye color: " + prop.FAllproperties["Eye color"]);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText("Race: " + prop.FAllproperties["Race"]);
        }
    }
}
