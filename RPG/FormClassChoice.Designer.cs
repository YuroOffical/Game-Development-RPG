namespace RPG
{
    partial class FormClassChoice
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
            this.label_FCC = new System.Windows.Forms.Label();
            this.picture_FCC = new System.Windows.Forms.PictureBox();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.label_desc1 = new System.Windows.Forms.Label();
            this.label_desc2 = new System.Windows.Forms.Label();
            this.label_desc3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_FCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FCC
            // 
            this.label_FCC.AutoSize = true;
            this.label_FCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_FCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_FCC.Font = new System.Drawing.Font("Sina-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FCC.Location = new System.Drawing.Point(22, 33);
            this.label_FCC.Name = "label_FCC";
            this.label_FCC.Size = new System.Drawing.Size(201, 47);
            this.label_FCC.TabIndex = 2;
            this.label_FCC.Text = "Picked Class";
            this.label_FCC.Click += new System.EventHandler(this.label1_Click);
            // 
            // picture_FCC
            // 
            this.picture_FCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_FCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_FCC.Image = global::RPG.Properties.Resources.Charastat0000;
            this.picture_FCC.Location = new System.Drawing.Point(327, 101);
            this.picture_FCC.Name = "picture_FCC";
            this.picture_FCC.Size = new System.Drawing.Size(238, 224);
            this.picture_FCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_FCC.TabIndex = 3;
            this.picture_FCC.TabStop = false;
            // 
            // btn_reject
            // 
            this.btn_reject.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reject.Location = new System.Drawing.Point(12, 285);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(264, 40);
            this.btn_reject.TabIndex = 5;
            this.btn_reject.Text = "Reject";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_accept.Location = new System.Drawing.Point(12, 239);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(264, 40);
            this.btn_accept.TabIndex = 6;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // label_desc1
            // 
            this.label_desc1.AutoSize = true;
            this.label_desc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_desc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_desc1.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_desc1.Location = new System.Drawing.Point(22, 123);
            this.label_desc1.Name = "label_desc1";
            this.label_desc1.Size = new System.Drawing.Size(51, 23);
            this.label_desc1.TabIndex = 7;
            this.label_desc1.Text = "label1";
            this.label_desc1.Click += new System.EventHandler(this.label_desc1_Click);
            // 
            // label_desc2
            // 
            this.label_desc2.AutoSize = true;
            this.label_desc2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_desc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_desc2.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_desc2.Location = new System.Drawing.Point(22, 155);
            this.label_desc2.Name = "label_desc2";
            this.label_desc2.Size = new System.Drawing.Size(51, 23);
            this.label_desc2.TabIndex = 8;
            this.label_desc2.Text = "label1";
            // 
            // label_desc3
            // 
            this.label_desc3.AutoSize = true;
            this.label_desc3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_desc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_desc3.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_desc3.Location = new System.Drawing.Point(22, 187);
            this.label_desc3.Name = "label_desc3";
            this.label_desc3.Size = new System.Drawing.Size(51, 23);
            this.label_desc3.TabIndex = 9;
            this.label_desc3.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Sina-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Character Features";
            // 
            // FormClassChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_desc3);
            this.Controls.Add(this.label_desc2);
            this.Controls.Add(this.label_desc1);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.picture_FCC);
            this.Controls.Add(this.label_FCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClassChoice";
            this.Text = "FormClassChoice";
            ((System.ComponentModel.ISupportInitialize)(this.picture_FCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_FCC;
        private PictureBox picture_FCC;
        private Button btn_reject;
        private Button btn_accept;
        private Label label_desc1;
        private Label label_desc2;
        private Label label_desc3;
        private Label label1;
    }
}