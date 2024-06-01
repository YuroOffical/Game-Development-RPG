namespace RPG
{
    partial class FormCharacterMenu
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
            this.lbl_Chara_name = new System.Windows.Forms.Label();
            this.txt_Chara_name = new System.Windows.Forms.TextBox();
            this.btn_class_warrior = new System.Windows.Forms.Button();
            this.btn_custom_class = new System.Windows.Forms.Button();
            this.btn_class_knight = new System.Windows.Forms.Button();
            this.btn_class_lancer = new System.Windows.Forms.Button();
            this.btn_class_thief = new System.Windows.Forms.Button();
            this.btn_class_wizard = new System.Windows.Forms.Button();
            this.btn_class_ranger = new System.Windows.Forms.Button();
            this.btn_class_archer = new System.Windows.Forms.Button();
            this.btn_class_mage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.track_d = new System.Windows.Forms.TrackBar();
            this.lbl_m = new System.Windows.Forms.Label();
            this.track_r = new System.Windows.Forms.TrackBar();
            this.track_m = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_r = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.SliderUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.button_stickboi = new System.Windows.Forms.Button();
            this.button_miko = new System.Windows.Forms.Button();
            this.button_curse = new System.Windows.Forms.Button();
            this.button_slayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.track_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_m)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Chara_name
            // 
            this.lbl_Chara_name.AutoSize = true;
            this.lbl_Chara_name.Location = new System.Drawing.Point(47, 80);
            this.lbl_Chara_name.Name = "lbl_Chara_name";
            this.lbl_Chara_name.Size = new System.Drawing.Size(93, 15);
            this.lbl_Chara_name.TabIndex = 0;
            this.lbl_Chara_name.Text = "Character Name";
            this.lbl_Chara_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Chara_name
            // 
            this.txt_Chara_name.Location = new System.Drawing.Point(146, 77);
            this.txt_Chara_name.Name = "txt_Chara_name";
            this.txt_Chara_name.Size = new System.Drawing.Size(220, 23);
            this.txt_Chara_name.TabIndex = 1;
            this.txt_Chara_name.Text = "Dave the Default :l";
            this.txt_Chara_name.TextChanged += new System.EventHandler(this.txt_Chara_name_TextChanged);
            // 
            // btn_class_warrior
            // 
            this.btn_class_warrior.Enabled = false;
            this.btn_class_warrior.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_warrior.Location = new System.Drawing.Point(201, -26);
            this.btn_class_warrior.Name = "btn_class_warrior";
            this.btn_class_warrior.Size = new System.Drawing.Size(22, 21);
            this.btn_class_warrior.TabIndex = 3;
            this.btn_class_warrior.Text = "Warrior";
            this.btn_class_warrior.UseVisualStyleBackColor = true;
            this.btn_class_warrior.Visible = false;
            this.btn_class_warrior.Click += new System.EventHandler(this.btn_class_warrior_Click);
            // 
            // btn_custom_class
            // 
            this.btn_custom_class.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_custom_class.Location = new System.Drawing.Point(47, 12);
            this.btn_custom_class.Name = "btn_custom_class";
            this.btn_custom_class.Size = new System.Drawing.Size(373, 48);
            this.btn_custom_class.TabIndex = 11;
            this.btn_custom_class.Text = "Creating Characters at its finest";
            this.btn_custom_class.UseVisualStyleBackColor = true;
            // 
            // btn_class_knight
            // 
            this.btn_class_knight.Enabled = false;
            this.btn_class_knight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_knight.Location = new System.Drawing.Point(238, -26);
            this.btn_class_knight.Name = "btn_class_knight";
            this.btn_class_knight.Size = new System.Drawing.Size(22, 21);
            this.btn_class_knight.TabIndex = 12;
            this.btn_class_knight.Text = "Knight";
            this.btn_class_knight.UseVisualStyleBackColor = true;
            this.btn_class_knight.Visible = false;
            this.btn_class_knight.Click += new System.EventHandler(this.btn_class_knight_Click);
            // 
            // btn_class_lancer
            // 
            this.btn_class_lancer.Enabled = false;
            this.btn_class_lancer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_lancer.Location = new System.Drawing.Point(275, -26);
            this.btn_class_lancer.Name = "btn_class_lancer";
            this.btn_class_lancer.Size = new System.Drawing.Size(22, 21);
            this.btn_class_lancer.TabIndex = 13;
            this.btn_class_lancer.Text = "Lancer";
            this.btn_class_lancer.UseVisualStyleBackColor = true;
            this.btn_class_lancer.Visible = false;
            this.btn_class_lancer.Click += new System.EventHandler(this.btn_class_lancer_Click);
            // 
            // btn_class_thief
            // 
            this.btn_class_thief.Enabled = false;
            this.btn_class_thief.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_thief.Location = new System.Drawing.Point(438, 12);
            this.btn_class_thief.Name = "btn_class_thief";
            this.btn_class_thief.Size = new System.Drawing.Size(22, 21);
            this.btn_class_thief.TabIndex = 14;
            this.btn_class_thief.Text = "Thief";
            this.btn_class_thief.UseVisualStyleBackColor = true;
            this.btn_class_thief.Visible = false;
            this.btn_class_thief.Click += new System.EventHandler(this.btn_class_thief_Click);
            // 
            // btn_class_wizard
            // 
            this.btn_class_wizard.Enabled = false;
            this.btn_class_wizard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_wizard.Location = new System.Drawing.Point(12, 39);
            this.btn_class_wizard.Name = "btn_class_wizard";
            this.btn_class_wizard.Size = new System.Drawing.Size(22, 21);
            this.btn_class_wizard.TabIndex = 15;
            this.btn_class_wizard.Text = "Wizard";
            this.btn_class_wizard.UseVisualStyleBackColor = true;
            this.btn_class_wizard.Visible = false;
            this.btn_class_wizard.Click += new System.EventHandler(this.btn_class_wizard_Click);
            // 
            // btn_class_ranger
            // 
            this.btn_class_ranger.Enabled = false;
            this.btn_class_ranger.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_ranger.Location = new System.Drawing.Point(438, 39);
            this.btn_class_ranger.Name = "btn_class_ranger";
            this.btn_class_ranger.Size = new System.Drawing.Size(22, 21);
            this.btn_class_ranger.TabIndex = 15;
            this.btn_class_ranger.Text = "Ranger";
            this.btn_class_ranger.UseVisualStyleBackColor = true;
            this.btn_class_ranger.Visible = false;
            this.btn_class_ranger.Click += new System.EventHandler(this.btn_class_ranger_Click);
            // 
            // btn_class_archer
            // 
            this.btn_class_archer.Enabled = false;
            this.btn_class_archer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_archer.Location = new System.Drawing.Point(12, 12);
            this.btn_class_archer.Name = "btn_class_archer";
            this.btn_class_archer.Size = new System.Drawing.Size(22, 21);
            this.btn_class_archer.TabIndex = 16;
            this.btn_class_archer.Text = "Archer";
            this.btn_class_archer.UseVisualStyleBackColor = true;
            this.btn_class_archer.Visible = false;
            this.btn_class_archer.Click += new System.EventHandler(this.btn_class_archer_Click);
            // 
            // btn_class_mage
            // 
            this.btn_class_mage.Enabled = false;
            this.btn_class_mage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_class_mage.Location = new System.Drawing.Point(12, 27);
            this.btn_class_mage.Name = "btn_class_mage";
            this.btn_class_mage.Size = new System.Drawing.Size(22, 21);
            this.btn_class_mage.TabIndex = 17;
            this.btn_class_mage.Text = "Mage";
            this.btn_class_mage.UseVisualStyleBackColor = true;
            this.btn_class_mage.Visible = false;
            this.btn_class_mage.Click += new System.EventHandler(this.btn_class_mage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(372, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // track_d
            // 
            this.track_d.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.track_d.Location = new System.Drawing.Point(51, 50);
            this.track_d.Name = "track_d";
            this.track_d.Size = new System.Drawing.Size(268, 45);
            this.track_d.TabIndex = 19;
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_m.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_m.Location = new System.Drawing.Point(331, 15);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(100, 23);
            this.lbl_m.TabIndex = 20;
            this.lbl_m.Text = "Mountinous";
            // 
            // track_r
            // 
            this.track_r.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.track_r.Location = new System.Drawing.Point(51, 84);
            this.track_r.Name = "track_r";
            this.track_r.Size = new System.Drawing.Size(268, 45);
            this.track_r.TabIndex = 21;
            // 
            // track_m
            // 
            this.track_m.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.track_m.Location = new System.Drawing.Point(51, 15);
            this.track_m.Name = "track_m";
            this.track_m.Size = new System.Drawing.Size(268, 45);
            this.track_m.TabIndex = 22;
            this.track_m.Scroll += new System.EventHandler(this.track_m_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_r);
            this.panel1.Controls.Add(this.lbl_d);
            this.panel1.Controls.Add(this.lbl_m);
            this.panel1.Controls.Add(this.track_r);
            this.panel1.Controls.Add(this.track_d);
            this.panel1.Controls.Add(this.track_m);
            this.panel1.Location = new System.Drawing.Point(12, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 134);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::RPG.Properties.Resources.Rng;
            this.pictureBox3.Location = new System.Drawing.Point(16, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::RPG.Properties.Resources.Dungeon;
            this.pictureBox2.Location = new System.Drawing.Point(15, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RPG.Properties.Resources.Mount1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_r.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_r.Location = new System.Drawing.Point(331, 84);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(116, 23);
            this.lbl_r.TabIndex = 24;
            this.lbl_r.Text = "Unpredictable";
            this.lbl_r.Click += new System.EventHandler(this.lbl_r_Click);
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_d.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_d.Location = new System.Drawing.Point(331, 50);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(84, 23);
            this.lbl_d.TabIndex = 23;
            this.lbl_d.Text = "Sprawling";
            // 
            // SliderUpdateTimer
            // 
            this.SliderUpdateTimer.Enabled = true;
            this.SliderUpdateTimer.Tick += new System.EventHandler(this.SliderUpdate);
            // 
            // button_stickboi
            // 
            this.button_stickboi.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_stickboi.Location = new System.Drawing.Point(179, 120);
            this.button_stickboi.Name = "button_stickboi";
            this.button_stickboi.Size = new System.Drawing.Size(107, 78);
            this.button_stickboi.TabIndex = 24;
            this.button_stickboi.Text = "Stick Prayer";
            this.button_stickboi.UseVisualStyleBackColor = true;
            this.button_stickboi.Click += new System.EventHandler(this.button_stickboi_Click);
            // 
            // button_miko
            // 
            this.button_miko.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_miko.Location = new System.Drawing.Point(179, 280);
            this.button_miko.Name = "button_miko";
            this.button_miko.Size = new System.Drawing.Size(107, 78);
            this.button_miko.TabIndex = 25;
            this.button_miko.Text = "Shrine Maiden";
            this.button_miko.UseVisualStyleBackColor = true;
            this.button_miko.Click += new System.EventHandler(this.button_miko_Click);
            // 
            // button_curse
            // 
            this.button_curse.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_curse.Location = new System.Drawing.Point(313, 203);
            this.button_curse.Name = "button_curse";
            this.button_curse.Size = new System.Drawing.Size(107, 78);
            this.button_curse.TabIndex = 26;
            this.button_curse.Text = "Curse User";
            this.button_curse.UseVisualStyleBackColor = true;
            this.button_curse.Click += new System.EventHandler(this.button_curse_Click);
            // 
            // button_slayer
            // 
            this.button_slayer.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_slayer.Location = new System.Drawing.Point(47, 203);
            this.button_slayer.Name = "button_slayer";
            this.button_slayer.Size = new System.Drawing.Size(107, 78);
            this.button_slayer.TabIndex = 27;
            this.button_slayer.Text = "The Slayer";
            this.button_slayer.UseVisualStyleBackColor = true;
            this.button_slayer.Click += new System.EventHandler(this.button_slayer_Click);
            // 
            // FormCharacterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(491, 526);
            this.Controls.Add(this.button_slayer);
            this.Controls.Add(this.button_curse);
            this.Controls.Add(this.button_miko);
            this.Controls.Add(this.button_stickboi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_class_mage);
            this.Controls.Add(this.btn_class_archer);
            this.Controls.Add(this.btn_class_ranger);
            this.Controls.Add(this.btn_class_wizard);
            this.Controls.Add(this.btn_class_thief);
            this.Controls.Add(this.btn_class_lancer);
            this.Controls.Add(this.btn_class_knight);
            this.Controls.Add(this.btn_custom_class);
            this.Controls.Add(this.btn_class_warrior);
            this.Controls.Add(this.txt_Chara_name);
            this.Controls.Add(this.lbl_Chara_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCharacterMenu";
            this.Text = "Boi";
            this.Load += new System.EventHandler(this.FormCharacterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_m)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Chara_name;
        private TextBox txt_Chara_name;
        private Button btn_class_warrior;
        private Button btn_custom_class;
        private Button btn_class_knight;
        private Button btn_class_lancer;
        private Button btn_class_thief;
        private Button btn_class_wizard;
        private Button btn_class_ranger;
        private Button btn_class_archer;
        private Button btn_class_mage;
        private Button button1;
        private TrackBar track_d;
        private Label lbl_m;
        private TrackBar track_r;
        private TrackBar track_m;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_r;
        private Label lbl_d;
        private System.Windows.Forms.Timer SliderUpdateTimer;
        private Button button_stickboi;
        private Button button_miko;
        private Button button_curse;
        private Button button_slayer;
    }
}