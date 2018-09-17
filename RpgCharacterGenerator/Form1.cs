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

    public partial class Main_Box : Form
    {

        private int StrenghtStatNum = 0;
        private int DexterityStatNum =0;
        private int WisdomStatNum =0;
        private int InteligenceStatNum =0;

        public Main_Box()
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
            //richTextBox1.AppendText("Race: " + prop.FAllproperties["Race"]);
        }

        private void Quit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectHero_Btn_Click(object sender, EventArgs e)
        {
            if (ProfilePicOpen.ShowDialog() == DialogResult.OK)
            {
                HeroProfileBox.Image = Image.FromFile(ProfilePicOpen.FileName);
                this.Text = string.Concat("Select Hero(" + ProfilePicOpen.FileName + ")");
            }
        }

        private void PicCLear_Btn_Click(object sender, EventArgs e)
        {
            HeroProfileBox.Image = null;
        }
        // statok kezelése
        private void StrenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            //karakterek kivizsgálása
            System.Text.RegularExpressions.Regex.IsMatch(StrenghtTextBox.Text, "  ^ [0-9]");
                  
                   //StrenghtStatNum = int.Parse(StrenghtTextBox.Text);
               
            
        }

        private void DexterityTextBox_TextChanged(object sender, EventArgs e)
        {
            DexterityStatNum = int.Parse(DexterityTextBox.Text);
        }

        private void WisdomTextBox_TextChanged(object sender, EventArgs e)
        {
            WisdomStatNum = int.Parse(WisdomTextBox.Text);
        }

        private void InteligenceTextBox_TextChanged(object sender, EventArgs e)
        {
            InteligenceStatNum = int.Parse(InteligenceTextBox.Text);
        }

        
    }
}
