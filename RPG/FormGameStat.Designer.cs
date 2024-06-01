namespace RPG
{
    partial class FormGameStat
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label_Mana = new System.Windows.Forms.Label();
            this.label_attack = new System.Windows.Forms.Label();
            this.label_defense = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_crit = new System.Windows.Forms.Label();
            this.label_str = new System.Windows.Forms.Label();
            this.label_dex = new System.Windows.Forms.Label();
            this.label_vit = new System.Windows.Forms.Label();
            this.label_agi = new System.Windows.Forms.Label();
            this.label_int = new System.Windows.Forms.Label();
            this.label_wis = new System.Windows.Forms.Label();
            this.label_special = new System.Windows.Forms.Label();
            this.label_cash = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_armor = new System.Windows.Forms.Label();
            this.button_str = new System.Windows.Forms.Button();
            this.button_dex = new System.Windows.Forms.Button();
            this.button_vit = new System.Windows.Forms.Button();
            this.button_agi = new System.Windows.Forms.Button();
            this.button_int = new System.Windows.Forms.Button();
            this.button_wis = new System.Windows.Forms.Button();
            this.label_sp = new System.Windows.Forms.Label();
            this.Realtime = new System.Windows.Forms.Timer(this.components);
            this.label_xp = new System.Windows.Forms.Label();
            this.button_skill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sina-Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(367, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_name.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(106, 23);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name : Eyboss";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_class.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_class.Location = new System.Drawing.Point(12, 36);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(108, 23);
            this.label_class.TabIndex = 2;
            this.label_class.Text = "Class : Stickboi";
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hp.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hp.Location = new System.Drawing.Point(12, 122);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(68, 29);
            this.label_hp.TabIndex = 3;
            this.label_hp.Text = "HP : 0";
            this.label_hp.Click += new System.EventHandler(this.label_hp_Click);
            // 
            // label_Mana
            // 
            this.label_Mana.AutoSize = true;
            this.label_Mana.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Mana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Mana.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Mana.Location = new System.Drawing.Point(12, 163);
            this.label_Mana.Name = "label_Mana";
            this.label_Mana.Size = new System.Drawing.Size(89, 29);
            this.label_Mana.TabIndex = 4;
            this.label_Mana.Text = "Mana : 0";
            // 
            // label_attack
            // 
            this.label_attack.AutoSize = true;
            this.label_attack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_attack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_attack.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_attack.Location = new System.Drawing.Point(12, 206);
            this.label_attack.Name = "label_attack";
            this.label_attack.Size = new System.Drawing.Size(76, 29);
            this.label_attack.TabIndex = 5;
            this.label_attack.Text = "STR : 5";
            // 
            // label_defense
            // 
            this.label_defense.AutoSize = true;
            this.label_defense.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_defense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_defense.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_defense.Location = new System.Drawing.Point(12, 248);
            this.label_defense.Name = "label_defense";
            this.label_defense.Size = new System.Drawing.Size(76, 29);
            this.label_defense.TabIndex = 6;
            this.label_defense.Text = "STR : 5";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_speed.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_speed.Location = new System.Drawing.Point(12, 290);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(76, 29);
            this.label_speed.TabIndex = 7;
            this.label_speed.Text = "STR : 5";
            // 
            // label_crit
            // 
            this.label_crit.AutoSize = true;
            this.label_crit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_crit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_crit.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_crit.Location = new System.Drawing.Point(12, 378);
            this.label_crit.Name = "label_crit";
            this.label_crit.Size = new System.Drawing.Size(76, 29);
            this.label_crit.TabIndex = 8;
            this.label_crit.Text = "STR : 5";
            // 
            // label_str
            // 
            this.label_str.AutoSize = true;
            this.label_str.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_str.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_str.Location = new System.Drawing.Point(349, 121);
            this.label_str.Name = "label_str";
            this.label_str.Size = new System.Drawing.Size(76, 29);
            this.label_str.TabIndex = 9;
            this.label_str.Text = "STR : 5";
            // 
            // label_dex
            // 
            this.label_dex.AutoSize = true;
            this.label_dex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dex.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dex.Location = new System.Drawing.Point(349, 162);
            this.label_dex.Name = "label_dex";
            this.label_dex.Size = new System.Drawing.Size(76, 29);
            this.label_dex.TabIndex = 10;
            this.label_dex.Text = "STR : 5";
            // 
            // label_vit
            // 
            this.label_vit.AutoSize = true;
            this.label_vit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_vit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_vit.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_vit.Location = new System.Drawing.Point(349, 205);
            this.label_vit.Name = "label_vit";
            this.label_vit.Size = new System.Drawing.Size(76, 29);
            this.label_vit.TabIndex = 11;
            this.label_vit.Text = "STR : 5";
            // 
            // label_agi
            // 
            this.label_agi.AutoSize = true;
            this.label_agi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_agi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_agi.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_agi.Location = new System.Drawing.Point(349, 247);
            this.label_agi.Name = "label_agi";
            this.label_agi.Size = new System.Drawing.Size(76, 29);
            this.label_agi.TabIndex = 12;
            this.label_agi.Text = "STR : 5";
            // 
            // label_int
            // 
            this.label_int.AutoSize = true;
            this.label_int.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_int.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_int.Location = new System.Drawing.Point(349, 289);
            this.label_int.Name = "label_int";
            this.label_int.Size = new System.Drawing.Size(76, 29);
            this.label_int.TabIndex = 13;
            this.label_int.Text = "STR : 5";
            // 
            // label_wis
            // 
            this.label_wis.AutoSize = true;
            this.label_wis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_wis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_wis.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_wis.Location = new System.Drawing.Point(349, 333);
            this.label_wis.Name = "label_wis";
            this.label_wis.Size = new System.Drawing.Size(76, 29);
            this.label_wis.TabIndex = 14;
            this.label_wis.Text = "STR : 5";
            // 
            // label_special
            // 
            this.label_special.AutoSize = true;
            this.label_special.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_special.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_special.Location = new System.Drawing.Point(12, 425);
            this.label_special.Name = "label_special";
            this.label_special.Size = new System.Drawing.Size(76, 29);
            this.label_special.TabIndex = 15;
            this.label_special.Text = "STR : 5";
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cash.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_cash.Location = new System.Drawing.Point(12, 63);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(64, 23);
            this.label_cash.TabIndex = 16;
            this.label_cash.Text = "Cash : 0";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_level.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_level.Location = new System.Drawing.Point(378, 9);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(66, 23);
            this.label_level.TabIndex = 17;
            this.label_level.Text = "Level : 0";
            // 
            // label_armor
            // 
            this.label_armor.AutoSize = true;
            this.label_armor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_armor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_armor.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_armor.Location = new System.Drawing.Point(12, 334);
            this.label_armor.Name = "label_armor";
            this.label_armor.Size = new System.Drawing.Size(76, 29);
            this.label_armor.TabIndex = 18;
            this.label_armor.Text = "STR : 5";
            // 
            // button_str
            // 
            this.button_str.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_str.Location = new System.Drawing.Point(305, 119);
            this.button_str.Name = "button_str";
            this.button_str.Size = new System.Drawing.Size(35, 33);
            this.button_str.TabIndex = 19;
            this.button_str.Text = "UP";
            this.button_str.UseVisualStyleBackColor = false;
            this.button_str.Click += new System.EventHandler(this.button_str_Click);
            // 
            // button_dex
            // 
            this.button_dex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_dex.Location = new System.Drawing.Point(305, 160);
            this.button_dex.Name = "button_dex";
            this.button_dex.Size = new System.Drawing.Size(35, 33);
            this.button_dex.TabIndex = 20;
            this.button_dex.Text = "UP";
            this.button_dex.UseVisualStyleBackColor = false;
            this.button_dex.Click += new System.EventHandler(this.button_dex_Click);
            // 
            // button_vit
            // 
            this.button_vit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_vit.Location = new System.Drawing.Point(305, 203);
            this.button_vit.Name = "button_vit";
            this.button_vit.Size = new System.Drawing.Size(35, 33);
            this.button_vit.TabIndex = 21;
            this.button_vit.Text = "UP";
            this.button_vit.UseVisualStyleBackColor = false;
            this.button_vit.Click += new System.EventHandler(this.button_vit_Click);
            // 
            // button_agi
            // 
            this.button_agi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_agi.Location = new System.Drawing.Point(305, 245);
            this.button_agi.Name = "button_agi";
            this.button_agi.Size = new System.Drawing.Size(35, 33);
            this.button_agi.TabIndex = 22;
            this.button_agi.Text = "UP";
            this.button_agi.UseVisualStyleBackColor = false;
            this.button_agi.Click += new System.EventHandler(this.button_agi_Click);
            // 
            // button_int
            // 
            this.button_int.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_int.Location = new System.Drawing.Point(305, 285);
            this.button_int.Name = "button_int";
            this.button_int.Size = new System.Drawing.Size(35, 33);
            this.button_int.TabIndex = 23;
            this.button_int.Text = "UP";
            this.button_int.UseVisualStyleBackColor = false;
            this.button_int.Click += new System.EventHandler(this.button_int_Click);
            // 
            // button_wis
            // 
            this.button_wis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_wis.Location = new System.Drawing.Point(305, 330);
            this.button_wis.Name = "button_wis";
            this.button_wis.Size = new System.Drawing.Size(35, 33);
            this.button_wis.TabIndex = 24;
            this.button_wis.Text = "UP";
            this.button_wis.UseVisualStyleBackColor = false;
            this.button_wis.Click += new System.EventHandler(this.button_wis_Click);
            // 
            // label_sp
            // 
            this.label_sp.AutoSize = true;
            this.label_sp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_sp.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sp.Location = new System.Drawing.Point(286, 63);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(158, 23);
            this.label_sp.TabIndex = 25;
            this.label_sp.Text = "Available Skill point : 0";
            this.label_sp.Click += new System.EventHandler(this.label1_Click);
            // 
            // Realtime
            // 
            this.Realtime.Enabled = true;
            this.Realtime.Tick += new System.EventHandler(this.Realtimetick);
            // 
            // label_xp
            // 
            this.label_xp.AutoSize = true;
            this.label_xp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_xp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_xp.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_xp.Location = new System.Drawing.Point(352, 36);
            this.label_xp.Name = "label_xp";
            this.label_xp.Size = new System.Drawing.Size(92, 23);
            this.label_xp.TabIndex = 26;
            this.label_xp.Text = "XP : XX/XX";
            this.label_xp.Click += new System.EventHandler(this.label_xp_Click);
            // 
            // button_skill
            // 
            this.button_skill.Font = new System.Drawing.Font("Sina-Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_skill.Location = new System.Drawing.Point(240, 406);
            this.button_skill.Name = "button_skill";
            this.button_skill.Size = new System.Drawing.Size(112, 58);
            this.button_skill.TabIndex = 27;
            this.button_skill.Text = "Skill";
            this.button_skill.UseVisualStyleBackColor = true;
            this.button_skill.Click += new System.EventHandler(this.button_skill_Click);
            // 
            // FormGameStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 476);
            this.Controls.Add(this.button_skill);
            this.Controls.Add(this.label_xp);
            this.Controls.Add(this.label_sp);
            this.Controls.Add(this.button_wis);
            this.Controls.Add(this.button_int);
            this.Controls.Add(this.button_agi);
            this.Controls.Add(this.button_vit);
            this.Controls.Add(this.button_dex);
            this.Controls.Add(this.button_str);
            this.Controls.Add(this.label_armor);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.label_special);
            this.Controls.Add(this.label_wis);
            this.Controls.Add(this.label_int);
            this.Controls.Add(this.label_agi);
            this.Controls.Add(this.label_vit);
            this.Controls.Add(this.label_dex);
            this.Controls.Add(this.label_str);
            this.Controls.Add(this.label_crit);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_defense);
            this.Controls.Add(this.label_attack);
            this.Controls.Add(this.label_Mana);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameStat";
            this.Text = "FormGameStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label_name;
        private Label label_class;
        private Label label_hp;
        private Label label_Mana;
        private Label label_attack;
        private Label label_defense;
        private Label label_speed;
        private Label label_crit;
        private Label label_str;
        private Label label_dex;
        private Label label_vit;
        private Label label_agi;
        private Label label_int;
        private Label label_wis;
        private Label label_special;
        private Label label_cash;
        private Label label_level;
        private Label label_armor;
        private Button button_str;
        private Button button_dex;
        private Button button_vit;
        private Button button_agi;
        private Button button_int;
        private Button button_wis;
        private Label label_sp;
        private System.Windows.Forms.Timer Realtime;
        private Label label_xp;
        private Button button_skill;
    }
}