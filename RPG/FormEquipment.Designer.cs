namespace RPG
{
    partial class FormEquipment
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
            this.label_cash = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_helm = new System.Windows.Forms.PictureBox();
            this.progressBarhelm = new System.Windows.Forms.ProgressBar();
            this.button_helm = new System.Windows.Forms.Button();
            this.label_helm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_chest = new System.Windows.Forms.Label();
            this.buttonchest = new System.Windows.Forms.Button();
            this.progressBarchest = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_glove = new System.Windows.Forms.Label();
            this.buttonglove = new System.Windows.Forms.Button();
            this.progressBarglove = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_leg = new System.Windows.Forms.Label();
            this.buttonleg = new System.Windows.Forms.Button();
            this.progressBarleg = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_wep = new System.Windows.Forms.Label();
            this.buttonwep = new System.Windows.Forms.Button();
            this.progressBarwep = new System.Windows.Forms.ProgressBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Realtime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_helm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cash.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cash.Location = new System.Drawing.Point(12, 38);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(116, 20);
            this.label_cash.TabIndex = 0;
            this.label_cash.Text = "Cash : 100 ඞ";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Sina-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(293, 571);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(108, 57);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Return";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_helm
            // 
            this.pictureBox_helm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_helm.Image = global::RPG.Properties.Resources.frame00002;
            this.pictureBox_helm.Location = new System.Drawing.Point(26, 73);
            this.pictureBox_helm.Name = "pictureBox_helm";
            this.pictureBox_helm.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_helm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_helm.TabIndex = 2;
            this.pictureBox_helm.TabStop = false;
            // 
            // progressBarhelm
            // 
            this.progressBarhelm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarhelm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarhelm.Location = new System.Drawing.Point(92, 110);
            this.progressBarhelm.Maximum = 210;
            this.progressBarhelm.Name = "progressBarhelm";
            this.progressBarhelm.Size = new System.Drawing.Size(284, 23);
            this.progressBarhelm.TabIndex = 3;
            // 
            // button_helm
            // 
            this.button_helm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_helm.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_helm.Location = new System.Drawing.Point(92, 73);
            this.button_helm.Name = "button_helm";
            this.button_helm.Size = new System.Drawing.Size(197, 31);
            this.button_helm.TabIndex = 4;
            this.button_helm.Text = "Upgrade Cost : 100 ඞ";
            this.button_helm.UseVisualStyleBackColor = false;
            this.button_helm.Click += new System.EventHandler(this.button_helm_Click);
            // 
            // label_helm
            // 
            this.label_helm.AutoSize = true;
            this.label_helm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_helm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_helm.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_helm.Location = new System.Drawing.Point(26, 140);
            this.label_helm.Name = "label_helm";
            this.label_helm.Size = new System.Drawing.Size(94, 24);
            this.label_helm.TabIndex = 5;
            this.label_helm.Text = "Level : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipment Upgrade";
            // 
            // label_chest
            // 
            this.label_chest.AutoSize = true;
            this.label_chest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_chest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_chest.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_chest.Location = new System.Drawing.Point(26, 246);
            this.label_chest.Name = "label_chest";
            this.label_chest.Size = new System.Drawing.Size(94, 24);
            this.label_chest.TabIndex = 10;
            this.label_chest.Text = "Level : 0";
            // 
            // buttonchest
            // 
            this.buttonchest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonchest.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonchest.Location = new System.Drawing.Point(92, 179);
            this.buttonchest.Name = "buttonchest";
            this.buttonchest.Size = new System.Drawing.Size(197, 31);
            this.buttonchest.TabIndex = 9;
            this.buttonchest.Text = "Upgrade Cost : 100 ඞ";
            this.buttonchest.UseVisualStyleBackColor = false;
            this.buttonchest.Click += new System.EventHandler(this.buttonchest_Click);
            // 
            // progressBarchest
            // 
            this.progressBarchest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarchest.Location = new System.Drawing.Point(92, 216);
            this.progressBarchest.Maximum = 210;
            this.progressBarchest.Name = "progressBarchest";
            this.progressBarchest.Size = new System.Drawing.Size(284, 23);
            this.progressBarchest.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RPG.Properties.Resources.frame0001;
            this.pictureBox1.Location = new System.Drawing.Point(26, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_glove
            // 
            this.label_glove.AutoSize = true;
            this.label_glove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_glove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_glove.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_glove.Location = new System.Drawing.Point(26, 354);
            this.label_glove.Name = "label_glove";
            this.label_glove.Size = new System.Drawing.Size(94, 24);
            this.label_glove.TabIndex = 14;
            this.label_glove.Text = "Level : 0";
            // 
            // buttonglove
            // 
            this.buttonglove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonglove.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonglove.Location = new System.Drawing.Point(92, 287);
            this.buttonglove.Name = "buttonglove";
            this.buttonglove.Size = new System.Drawing.Size(197, 31);
            this.buttonglove.TabIndex = 13;
            this.buttonglove.Text = "Upgrade Cost : 100 ඞ";
            this.buttonglove.UseVisualStyleBackColor = false;
            this.buttonglove.Click += new System.EventHandler(this.buttonglove_Click);
            // 
            // progressBarglove
            // 
            this.progressBarglove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarglove.Location = new System.Drawing.Point(92, 324);
            this.progressBarglove.Maximum = 210;
            this.progressBarglove.Name = "progressBarglove";
            this.progressBarglove.Size = new System.Drawing.Size(284, 23);
            this.progressBarglove.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::RPG.Properties.Resources.frame0002;
            this.pictureBox2.Location = new System.Drawing.Point(26, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label_leg
            // 
            this.label_leg.AutoSize = true;
            this.label_leg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_leg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_leg.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_leg.Location = new System.Drawing.Point(26, 461);
            this.label_leg.Name = "label_leg";
            this.label_leg.Size = new System.Drawing.Size(94, 24);
            this.label_leg.TabIndex = 18;
            this.label_leg.Text = "Level : 0";
            // 
            // buttonleg
            // 
            this.buttonleg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonleg.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonleg.Location = new System.Drawing.Point(92, 394);
            this.buttonleg.Name = "buttonleg";
            this.buttonleg.Size = new System.Drawing.Size(197, 31);
            this.buttonleg.TabIndex = 17;
            this.buttonleg.Text = "Upgrade Cost : 100 ඞ";
            this.buttonleg.UseVisualStyleBackColor = false;
            this.buttonleg.Click += new System.EventHandler(this.buttonleg_Click);
            // 
            // progressBarleg
            // 
            this.progressBarleg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarleg.Location = new System.Drawing.Point(92, 431);
            this.progressBarleg.Maximum = 210;
            this.progressBarleg.Name = "progressBarleg";
            this.progressBarleg.Size = new System.Drawing.Size(284, 23);
            this.progressBarleg.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::RPG.Properties.Resources.frame0003;
            this.pictureBox3.Location = new System.Drawing.Point(26, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label_wep
            // 
            this.label_wep.AutoSize = true;
            this.label_wep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_wep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_wep.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_wep.Location = new System.Drawing.Point(26, 571);
            this.label_wep.Name = "label_wep";
            this.label_wep.Size = new System.Drawing.Size(94, 24);
            this.label_wep.TabIndex = 22;
            this.label_wep.Text = "Level : 0";
            // 
            // buttonwep
            // 
            this.buttonwep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonwep.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonwep.Location = new System.Drawing.Point(92, 504);
            this.buttonwep.Name = "buttonwep";
            this.buttonwep.Size = new System.Drawing.Size(197, 31);
            this.buttonwep.TabIndex = 21;
            this.buttonwep.Text = "Upgrade Cost : 100 ඞ";
            this.buttonwep.UseVisualStyleBackColor = false;
            this.buttonwep.Click += new System.EventHandler(this.buttonwep_Click);
            // 
            // progressBarwep
            // 
            this.progressBarwep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBarwep.Location = new System.Drawing.Point(92, 541);
            this.progressBarwep.Maximum = 210;
            this.progressBarwep.Name = "progressBarwep";
            this.progressBarwep.Size = new System.Drawing.Size(284, 23);
            this.progressBarwep.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::RPG.Properties.Resources.frame0004;
            this.pictureBox4.Location = new System.Drawing.Point(26, 504);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // Realtime
            // 
            this.Realtime.Enabled = true;
            this.Realtime.Interval = 30;
            this.Realtime.Tick += new System.EventHandler(this.Realtimetick);
            // 
            // FormEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 640);
            this.Controls.Add(this.label_wep);
            this.Controls.Add(this.buttonwep);
            this.Controls.Add(this.progressBarwep);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_leg);
            this.Controls.Add(this.buttonleg);
            this.Controls.Add(this.progressBarleg);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_glove);
            this.Controls.Add(this.buttonglove);
            this.Controls.Add(this.progressBarglove);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_chest);
            this.Controls.Add(this.buttonchest);
            this.Controls.Add(this.progressBarchest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_helm);
            this.Controls.Add(this.button_helm);
            this.Controls.Add(this.progressBarhelm);
            this.Controls.Add(this.pictureBox_helm);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_cash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEquipment";
            this.Text = "FormEquipment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_helm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_cash;
        private Button button_exit;
        private PictureBox pictureBox_helm;
        private ProgressBar progressBarhelm;
        private Button button_helm;
        private Label label_helm;
        private Label label3;
        private Label label_chest;
        private Button buttonchest;
        private ProgressBar progressBarchest;
        private PictureBox pictureBox1;
        private Label label_glove;
        private Button buttonglove;
        private ProgressBar progressBarglove;
        private PictureBox pictureBox2;
        private Label label_leg;
        private Button buttonleg;
        private ProgressBar progressBarleg;
        private PictureBox pictureBox3;
        private Label label_wep;
        private Button buttonwep;
        private ProgressBar progressBarwep;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer Realtime;
    }
}