namespace RpgCharacterGenerator
{
    partial class Main_Box
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SelectHero_Btn = new System.Windows.Forms.Button();
            this.PicCLear_Btn = new System.Windows.Forms.Button();
            this.Quit_Btn = new System.Windows.Forms.Button();
            this.HeroProfileBox = new System.Windows.Forms.PictureBox();
            this.ProfilePicOpen = new System.Windows.Forms.OpenFileDialog();
            this.ProfileInfo = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StenghtStat = new System.Windows.Forms.Label();
            this.DexterityStat = new System.Windows.Forms.Label();
            this.WisdomStat = new System.Windows.Forms.Label();
            this.InteliStat = new System.Windows.Forms.Label();
            this.StrenghtTextBox = new System.Windows.Forms.TextBox();
            this.StrenghtPlus = new System.Windows.Forms.Button();
            this.DexterityPlus = new System.Windows.Forms.Button();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.WisdomPlus = new System.Windows.Forms.Button();
            this.WisdomTextBox = new System.Windows.Forms.TextBox();
            this.InteligencePlus = new System.Windows.Forms.Button();
            this.InteligenceTextBox = new System.Windows.Forms.TextBox();
            this.InteligenceMinus = new System.Windows.Forms.Button();
            this.WisdomMinus = new System.Windows.Forms.Button();
            this.DexterityMinus = new System.Windows.Forms.Button();
            this.StrenghtMinus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeroProfileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(595, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(69, 23);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // SelectHero_Btn
            // 
            this.SelectHero_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectHero_Btn.Location = new System.Drawing.Point(168, 72);
            this.SelectHero_Btn.Name = "SelectHero_Btn";
            this.SelectHero_Btn.Size = new System.Drawing.Size(85, 22);
            this.SelectHero_Btn.TabIndex = 2;
            this.SelectHero_Btn.Text = "Select Hero";
            this.SelectHero_Btn.UseVisualStyleBackColor = true;
            this.SelectHero_Btn.Click += new System.EventHandler(this.SelectHero_Btn_Click);
            // 
            // PicCLear_Btn
            // 
            this.PicCLear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PicCLear_Btn.Location = new System.Drawing.Point(168, 100);
            this.PicCLear_Btn.Name = "PicCLear_Btn";
            this.PicCLear_Btn.Size = new System.Drawing.Size(85, 22);
            this.PicCLear_Btn.TabIndex = 3;
            this.PicCLear_Btn.Text = "Clear";
            this.PicCLear_Btn.UseVisualStyleBackColor = true;
            this.PicCLear_Btn.Click += new System.EventHandler(this.PicCLear_Btn_Click);
            // 
            // Quit_Btn
            // 
            this.Quit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quit_Btn.Location = new System.Drawing.Point(637, 277);
            this.Quit_Btn.Name = "Quit_Btn";
            this.Quit_Btn.Size = new System.Drawing.Size(85, 22);
            this.Quit_Btn.TabIndex = 4;
            this.Quit_Btn.Text = "Quit";
            this.Quit_Btn.UseVisualStyleBackColor = true;
            this.Quit_Btn.Click += new System.EventHandler(this.Quit_Btn_Click);
            // 
            // HeroProfileBox
            // 
            this.HeroProfileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeroProfileBox.Location = new System.Drawing.Point(12, 45);
            this.HeroProfileBox.Name = "HeroProfileBox";
            this.HeroProfileBox.Size = new System.Drawing.Size(150, 150);
            this.HeroProfileBox.TabIndex = 5;
            this.HeroProfileBox.TabStop = false;
            // 
            // ProfilePicOpen
            // 
            this.ProfilePicOpen.FileName = "openFileDialog1";
            this.ProfilePicOpen.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG";
            // 
            // ProfileInfo
            // 
            this.ProfileInfo.AutoSize = true;
            this.ProfileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProfileInfo.Location = new System.Drawing.Point(168, 46);
            this.ProfileInfo.Name = "ProfileInfo";
            this.ProfileInfo.Size = new System.Drawing.Size(50, 16);
            this.ProfileInfo.TabIndex = 6;
            this.ProfileInfo.Text = "Level:";
            // 
            // LevelBox
            // 
            this.LevelBox.Location = new System.Drawing.Point(215, 45);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(38, 20);
            this.LevelBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hero\'s name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 9;
            // 
            // StenghtStat
            // 
            this.StenghtStat.AutoSize = true;
            this.StenghtStat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StenghtStat.Location = new System.Drawing.Point(292, 9);
            this.StenghtStat.Name = "StenghtStat";
            this.StenghtStat.Size = new System.Drawing.Size(80, 19);
            this.StenghtStat.TabIndex = 10;
            this.StenghtStat.Text = "Strenght";
            // 
            // DexterityStat
            // 
            this.DexterityStat.AutoSize = true;
            this.DexterityStat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DexterityStat.Location = new System.Drawing.Point(286, 42);
            this.DexterityStat.Name = "DexterityStat";
            this.DexterityStat.Size = new System.Drawing.Size(86, 19);
            this.DexterityStat.TabIndex = 11;
            this.DexterityStat.Text = "Dexterity";
            // 
            // WisdomStat
            // 
            this.WisdomStat.AutoSize = true;
            this.WisdomStat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WisdomStat.Location = new System.Drawing.Point(296, 76);
            this.WisdomStat.Name = "WisdomStat";
            this.WisdomStat.Size = new System.Drawing.Size(73, 19);
            this.WisdomStat.TabIndex = 12;
            this.WisdomStat.Text = "Wisdom";
            // 
            // InteliStat
            // 
            this.InteliStat.AutoSize = true;
            this.InteliStat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InteliStat.Location = new System.Drawing.Point(268, 109);
            this.InteliStat.Name = "InteliStat";
            this.InteliStat.Size = new System.Drawing.Size(101, 19);
            this.InteliStat.TabIndex = 13;
            this.InteliStat.Text = "Inteligence";
            // 
            // StrenghtTextBox
            // 
            this.StrenghtTextBox.Location = new System.Drawing.Point(424, 10);
            this.StrenghtTextBox.Name = "StrenghtTextBox";
            this.StrenghtTextBox.Size = new System.Drawing.Size(32, 20);
            this.StrenghtTextBox.TabIndex = 14;
            this.StrenghtTextBox.TextChanged += new System.EventHandler(this.StrenghtTextBox_TextChanged);
            // 
            // StrenghtPlus
            // 
            this.StrenghtPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StrenghtPlus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrenghtPlus.Location = new System.Drawing.Point(381, 10);
            this.StrenghtPlus.Name = "StrenghtPlus";
            this.StrenghtPlus.Size = new System.Drawing.Size(37, 20);
            this.StrenghtPlus.TabIndex = 19;
            this.StrenghtPlus.Text = "+";
            this.StrenghtPlus.UseVisualStyleBackColor = true;
            // 
            // DexterityPlus
            // 
            this.DexterityPlus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DexterityPlus.Location = new System.Drawing.Point(381, 41);
            this.DexterityPlus.Name = "DexterityPlus";
            this.DexterityPlus.Size = new System.Drawing.Size(37, 20);
            this.DexterityPlus.TabIndex = 22;
            this.DexterityPlus.Text = "+";
            this.DexterityPlus.UseVisualStyleBackColor = true;
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.Location = new System.Drawing.Point(424, 41);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.Size = new System.Drawing.Size(32, 20);
            this.DexterityTextBox.TabIndex = 20;
            this.DexterityTextBox.TextChanged += new System.EventHandler(this.DexterityTextBox_TextChanged);
            // 
            // WisdomPlus
            // 
            this.WisdomPlus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WisdomPlus.Location = new System.Drawing.Point(381, 76);
            this.WisdomPlus.Name = "WisdomPlus";
            this.WisdomPlus.Size = new System.Drawing.Size(37, 20);
            this.WisdomPlus.TabIndex = 25;
            this.WisdomPlus.Text = "+";
            this.WisdomPlus.UseVisualStyleBackColor = true;
            // 
            // WisdomTextBox
            // 
            this.WisdomTextBox.Location = new System.Drawing.Point(424, 76);
            this.WisdomTextBox.Name = "WisdomTextBox";
            this.WisdomTextBox.Size = new System.Drawing.Size(32, 20);
            this.WisdomTextBox.TabIndex = 23;
            this.WisdomTextBox.TextChanged += new System.EventHandler(this.WisdomTextBox_TextChanged);
            // 
            // InteligencePlus
            // 
            this.InteligencePlus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InteligencePlus.Location = new System.Drawing.Point(381, 108);
            this.InteligencePlus.Name = "InteligencePlus";
            this.InteligencePlus.Size = new System.Drawing.Size(37, 20);
            this.InteligencePlus.TabIndex = 28;
            this.InteligencePlus.Text = "+";
            this.InteligencePlus.UseVisualStyleBackColor = true;
            // 
            // InteligenceTextBox
            // 
            this.InteligenceTextBox.Location = new System.Drawing.Point(424, 108);
            this.InteligenceTextBox.Name = "InteligenceTextBox";
            this.InteligenceTextBox.Size = new System.Drawing.Size(32, 20);
            this.InteligenceTextBox.TabIndex = 26;
            this.InteligenceTextBox.TextChanged += new System.EventHandler(this.InteligenceTextBox_TextChanged);
            // 
            // InteligenceMinus
            // 
            this.InteligenceMinus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InteligenceMinus.Location = new System.Drawing.Point(462, 108);
            this.InteligenceMinus.Name = "InteligenceMinus";
            this.InteligenceMinus.Size = new System.Drawing.Size(37, 20);
            this.InteligenceMinus.TabIndex = 32;
            this.InteligenceMinus.Text = "-";
            this.InteligenceMinus.UseVisualStyleBackColor = true;
            // 
            // WisdomMinus
            // 
            this.WisdomMinus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WisdomMinus.Location = new System.Drawing.Point(462, 76);
            this.WisdomMinus.Name = "WisdomMinus";
            this.WisdomMinus.Size = new System.Drawing.Size(37, 20);
            this.WisdomMinus.TabIndex = 31;
            this.WisdomMinus.Text = "-";
            this.WisdomMinus.UseVisualStyleBackColor = true;
            // 
            // DexterityMinus
            // 
            this.DexterityMinus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DexterityMinus.Location = new System.Drawing.Point(462, 41);
            this.DexterityMinus.Name = "DexterityMinus";
            this.DexterityMinus.Size = new System.Drawing.Size(37, 20);
            this.DexterityMinus.TabIndex = 30;
            this.DexterityMinus.Text = "-";
            this.DexterityMinus.UseVisualStyleBackColor = true;
            // 
            // StrenghtMinus
            // 
            this.StrenghtMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StrenghtMinus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrenghtMinus.Location = new System.Drawing.Point(462, 10);
            this.StrenghtMinus.Name = "StrenghtMinus";
            this.StrenghtMinus.Size = new System.Drawing.Size(37, 20);
            this.StrenghtMinus.TabIndex = 29;
            this.StrenghtMinus.Text = "-";
            this.StrenghtMinus.UseVisualStyleBackColor = true;
            // 
            // Main_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.InteligenceMinus);
            this.Controls.Add(this.WisdomMinus);
            this.Controls.Add(this.DexterityMinus);
            this.Controls.Add(this.StrenghtMinus);
            this.Controls.Add(this.InteligencePlus);
            this.Controls.Add(this.InteligenceTextBox);
            this.Controls.Add(this.WisdomPlus);
            this.Controls.Add(this.WisdomTextBox);
            this.Controls.Add(this.DexterityPlus);
            this.Controls.Add(this.DexterityTextBox);
            this.Controls.Add(this.StrenghtPlus);
            this.Controls.Add(this.StrenghtTextBox);
            this.Controls.Add(this.InteliStat);
            this.Controls.Add(this.WisdomStat);
            this.Controls.Add(this.DexterityStat);
            this.Controls.Add(this.StenghtStat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelBox);
            this.Controls.Add(this.ProfileInfo);
            this.Controls.Add(this.HeroProfileBox);
            this.Controls.Add(this.Quit_Btn);
            this.Controls.Add(this.PicCLear_Btn);
            this.Controls.Add(this.SelectHero_Btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Main_Box";
            this.Text = "Character generator";
            
            ((System.ComponentModel.ISupportInitialize)(this.HeroProfileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SelectHero_Btn;
        private System.Windows.Forms.Button PicCLear_Btn;
        private System.Windows.Forms.Button Quit_Btn;
        private System.Windows.Forms.PictureBox HeroProfileBox;
        private System.Windows.Forms.OpenFileDialog ProfilePicOpen;
        private System.Windows.Forms.Label ProfileInfo;
        private System.Windows.Forms.TextBox LevelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label StenghtStat;
        private System.Windows.Forms.Label DexterityStat;
        private System.Windows.Forms.Label WisdomStat;
        private System.Windows.Forms.Label InteliStat;
        private System.Windows.Forms.TextBox StrenghtTextBox;
        private System.Windows.Forms.Button StrenghtPlus;
        private System.Windows.Forms.Button DexterityPlus;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.Button WisdomPlus;
        private System.Windows.Forms.TextBox WisdomTextBox;
        private System.Windows.Forms.Button InteligencePlus;
        private System.Windows.Forms.TextBox InteligenceTextBox;
        private System.Windows.Forms.Button InteligenceMinus;
        private System.Windows.Forms.Button WisdomMinus;
        private System.Windows.Forms.Button DexterityMinus;
        private System.Windows.Forms.Button StrenghtMinus;
    }
}

