namespace RPG
{
    partial class FormWinLoss
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
            this.panel_expbar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.label_screen = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_exp = new System.Windows.Forms.Label();
            this.label_newskill = new System.Windows.Forms.Label();
            this.label_levelup = new System.Windows.Forms.Label();
            this.label_taos = new System.Windows.Forms.Label();
            this.label_bonus = new System.Windows.Forms.Label();
            this.panel_expbarblue = new System.Windows.Forms.Panel();
            this.Realtime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_earn_cash = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_exp_earn = new System.Windows.Forms.Label();
            this.Expbar = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.Expvalue = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_expbar
            // 
            this.panel_expbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_expbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_expbar.Location = new System.Drawing.Point(25, 419);
            this.panel_expbar.Name = "panel_expbar";
            this.panel_expbar.Size = new System.Drawing.Size(401, 31);
            this.panel_expbar.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_title.Font = new System.Drawing.Font("Sina-Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(12, 56);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(141, 64);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Noice";
            this.label_title.UseWaitCursor = true;
            this.label_title.Visible = false;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_text.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text.Location = new System.Drawing.Point(230, 64);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(128, 56);
            this.label_text.TabIndex = 2;
            this.label_text.Text = "Ya did it\r\nhave a cookie\r\n";
            this.label_text.UseWaitCursor = true;
            this.label_text.Visible = false;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_player.Image = global::RPG.Properties.Resources.Winning;
            this.pictureBox_player.Location = new System.Drawing.Point(285, 203);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(141, 210);
            this.pictureBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_player.TabIndex = 4;
            this.pictureBox_player.TabStop = false;
            this.pictureBox_player.UseWaitCursor = true;
            // 
            // label_screen
            // 
            this.label_screen.AutoSize = true;
            this.label_screen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_screen.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_screen.Location = new System.Drawing.Point(125, 9);
            this.label_screen.Name = "label_screen";
            this.label_screen.Size = new System.Drawing.Size(156, 33);
            this.label_screen.TabIndex = 5;
            this.label_screen.Text = "Victory Screen";
            this.label_screen.UseWaitCursor = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_name.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(25, 340);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(120, 23);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Dave the Default\r\n";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_level.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_level.Location = new System.Drawing.Point(25, 366);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(66, 23);
            this.label_level.TabIndex = 8;
            this.label_level.Text = "Level : 1";
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_exp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_exp.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_exp.Location = new System.Drawing.Point(25, 392);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(153, 23);
            this.label_exp.TabIndex = 9;
            this.label_exp.Text = "Exp = XXXX / XXXX";
            // 
            // label_newskill
            // 
            this.label_newskill.AutoSize = true;
            this.label_newskill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_newskill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_newskill.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_newskill.Location = new System.Drawing.Point(12, 255);
            this.label_newskill.Name = "label_newskill";
            this.label_newskill.Size = new System.Drawing.Size(184, 29);
            this.label_newskill.TabIndex = 10;
            this.label_newskill.Text = "Ya learn a new skill!";
            this.label_newskill.Visible = false;
            // 
            // label_levelup
            // 
            this.label_levelup.AutoSize = true;
            this.label_levelup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_levelup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_levelup.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_levelup.Location = new System.Drawing.Point(12, 216);
            this.label_levelup.Name = "label_levelup";
            this.label_levelup.Size = new System.Drawing.Size(166, 29);
            this.label_levelup.TabIndex = 11;
            this.label_levelup.Text = "You\'ve leveled up!";
            this.label_levelup.Visible = false;
            // 
            // label_taos
            // 
            this.label_taos.AutoSize = true;
            this.label_taos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_taos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_taos.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_taos.Location = new System.Drawing.Point(12, 132);
            this.label_taos.Name = "label_taos";
            this.label_taos.Size = new System.Drawing.Size(189, 29);
            this.label_taos.TabIndex = 12;
            this.label_taos.Text = "You defeated (name)";
            this.label_taos.UseWaitCursor = true;
            this.label_taos.Visible = false;
            // 
            // label_bonus
            // 
            this.label_bonus.AutoSize = true;
            this.label_bonus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_bonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_bonus.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bonus.Location = new System.Drawing.Point(12, 292);
            this.label_bonus.Name = "label_bonus";
            this.label_bonus.Size = new System.Drawing.Size(100, 29);
            this.label_bonus.TabIndex = 13;
            this.label_bonus.Text = "Bonus SP!";
            this.label_bonus.Visible = false;
            // 
            // panel_expbarblue
            // 
            this.panel_expbarblue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_expbarblue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_expbarblue.Location = new System.Drawing.Point(25, 419);
            this.panel_expbarblue.Name = "panel_expbarblue";
            this.panel_expbarblue.Size = new System.Drawing.Size(32, 31);
            this.panel_expbarblue.TabIndex = 1;
            // 
            // Realtime
            // 
            this.Realtime.Interval = 50;
            this.Realtime.Tick += new System.EventHandler(this.Realtimetick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(25, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_earn_cash
            // 
            this.label_earn_cash.AutoSize = true;
            this.label_earn_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_earn_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_earn_cash.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_earn_cash.Location = new System.Drawing.Point(12, 175);
            this.label_earn_cash.Name = "label_earn_cash";
            this.label_earn_cash.Size = new System.Drawing.Size(215, 29);
            this.label_earn_cash.TabIndex = 15;
            this.label_earn_cash.Text = "You\'ve earn xxxxxxx ඞ  ";
            this.label_earn_cash.UseWaitCursor = true;
            this.label_earn_cash.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(453, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 634);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(-8, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 634);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(-4, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 23);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(0, -21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(463, 23);
            this.panel5.TabIndex = 18;
            // 
            // label_exp_earn
            // 
            this.label_exp_earn.AutoSize = true;
            this.label_exp_earn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_exp_earn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_exp_earn.Font = new System.Drawing.Font("Sina-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_exp_earn.Location = new System.Drawing.Point(285, 165);
            this.label_exp_earn.Name = "label_exp_earn";
            this.label_exp_earn.Size = new System.Drawing.Size(73, 29);
            this.label_exp_earn.TabIndex = 19;
            this.label_exp_earn.Text = "+ 0 XP\r\n";
            this.label_exp_earn.UseWaitCursor = true;
            this.label_exp_earn.Visible = false;
            // 
            // Expbar
            // 
            this.Expbar.Interval = 20;
            this.Expbar.Tick += new System.EventHandler(this.Expbartick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Expvalue
            // 
            this.Expvalue.Enabled = true;
            this.Expvalue.Interval = 5;
            this.Expvalue.Tick += new System.EventHandler(this.Expvaluetick);
            // 
            // FormWinLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(455, 555);
            this.Controls.Add(this.panel_expbarblue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_exp_earn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_earn_cash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_bonus);
            this.Controls.Add(this.label_taos);
            this.Controls.Add(this.label_levelup);
            this.Controls.Add(this.label_newskill);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_screen);
            this.Controls.Add(this.pictureBox_player);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_expbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWinLoss";
            this.Text = "FormWinLoss";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_expbar;
        private Label label_title;
        private Label label_text;
        private PictureBox pictureBox_player;
        private Label label_screen;
        private Label label_name;
        private Label label_level;
        private Label label_exp;
        private Label label_newskill;
        private Label label_levelup;
        private Label label_taos;
        private Label label_bonus;
        private Panel panel_expbarblue;
        private System.Windows.Forms.Timer Realtime;
        private Button button1;
        private Label label_earn_cash;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label_exp_earn;
        private System.Windows.Forms.Timer Expbar;
        private Button button2;
        private System.Windows.Forms.Timer Expvalue;
    }
}