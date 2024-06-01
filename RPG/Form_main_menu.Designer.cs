namespace RPG
{
    partial class Form_main_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main_menu));
            this.Lbl_maine_menu = new System.Windows.Forms.Label();
            this.button_mm_start = new System.Windows.Forms.Button();
            this.button_mm_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_mm_cc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_maine_menu
            // 
            this.Lbl_maine_menu.AutoSize = true;
            this.Lbl_maine_menu.Font = new System.Drawing.Font("Informal Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_maine_menu.Location = new System.Drawing.Point(44, 26);
            this.Lbl_maine_menu.Name = "Lbl_maine_menu";
            this.Lbl_maine_menu.Size = new System.Drawing.Size(717, 69);
            this.Lbl_maine_menu.TabIndex = 0;
            this.Lbl_maine_menu.Text = "The Game : Suffering Edition";
            // 
            // button_mm_start
            // 
            this.button_mm_start.Font = new System.Drawing.Font("Sina-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mm_start.Location = new System.Drawing.Point(452, 234);
            this.button_mm_start.Name = "button_mm_start";
            this.button_mm_start.Size = new System.Drawing.Size(188, 43);
            this.button_mm_start.TabIndex = 1;
            this.button_mm_start.Text = "Start";
            this.button_mm_start.UseVisualStyleBackColor = true;
            this.button_mm_start.Click += new System.EventHandler(this.button_mm_start_Click);
            // 
            // button_mm_exit
            // 
            this.button_mm_exit.Font = new System.Drawing.Font("Sina-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mm_exit.Location = new System.Drawing.Point(452, 343);
            this.button_mm_exit.Name = "button_mm_exit";
            this.button_mm_exit.Size = new System.Drawing.Size(188, 43);
            this.button_mm_exit.TabIndex = 3;
            this.button_mm_exit.Text = "U weak";
            this.button_mm_exit.UseVisualStyleBackColor = true;
            this.button_mm_exit.Click += new System.EventHandler(this.button_mm_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-195, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1006, 588);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_mm_cc
            // 
            this.button_mm_cc.Font = new System.Drawing.Font("Sina-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mm_cc.Location = new System.Drawing.Point(452, 135);
            this.button_mm_cc.Name = "button_mm_cc";
            this.button_mm_cc.Size = new System.Drawing.Size(188, 43);
            this.button_mm_cc.TabIndex = 5;
            this.button_mm_cc.Text = "Character Creator";
            this.button_mm_cc.UseVisualStyleBackColor = true;
            this.button_mm_cc.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_mm_cc);
            this.Controls.Add(this.button_mm_exit);
            this.Controls.Add(this.button_mm_start);
            this.Controls.Add(this.Lbl_maine_menu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_main_menu";
            this.Text = "Suffering the game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_maine_menu;
        private Button button_mm_start;
        private Button button_mm_exit;
        private PictureBox pictureBox1;
        private Button button_mm_cc;
    }
}