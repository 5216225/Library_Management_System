namespace LMS
{
    partial class ChangePassword
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
            this.oldpsw_lbl = new System.Windows.Forms.Label();
            this.newpsw_lbl = new System.Windows.Forms.Label();
            this.confirmpsw_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chngpsw_btn = new System.Windows.Forms.Button();
            this.chngpsw_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldpsw_lbl
            // 
            this.oldpsw_lbl.AutoSize = true;
            this.oldpsw_lbl.Location = new System.Drawing.Point(12, 62);
            this.oldpsw_lbl.Name = "oldpsw_lbl";
            this.oldpsw_lbl.Size = new System.Drawing.Size(72, 13);
            this.oldpsw_lbl.TabIndex = 0;
            this.oldpsw_lbl.Text = "Old Password";
            // 
            // newpsw_lbl
            // 
            this.newpsw_lbl.AutoSize = true;
            this.newpsw_lbl.Location = new System.Drawing.Point(12, 108);
            this.newpsw_lbl.Name = "newpsw_lbl";
            this.newpsw_lbl.Size = new System.Drawing.Size(78, 13);
            this.newpsw_lbl.TabIndex = 1;
            this.newpsw_lbl.Text = "New Password";
            // 
            // confirmpsw_lbl
            // 
            this.confirmpsw_lbl.AutoSize = true;
            this.confirmpsw_lbl.Location = new System.Drawing.Point(12, 150);
            this.confirmpsw_lbl.Name = "confirmpsw_lbl";
            this.confirmpsw_lbl.Size = new System.Drawing.Size(91, 13);
            this.confirmpsw_lbl.TabIndex = 2;
            this.confirmpsw_lbl.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 5;
            // 
            // chngpsw_btn
            // 
            this.chngpsw_btn.Location = new System.Drawing.Point(70, 193);
            this.chngpsw_btn.Name = "chngpsw_btn";
            this.chngpsw_btn.Size = new System.Drawing.Size(143, 40);
            this.chngpsw_btn.TabIndex = 6;
            this.chngpsw_btn.Text = "Change Password";
            this.chngpsw_btn.UseVisualStyleBackColor = true;
            // 
            // chngpsw_lbl
            // 
            this.chngpsw_lbl.AutoSize = true;
            this.chngpsw_lbl.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngpsw_lbl.Location = new System.Drawing.Point(10, 9);
            this.chngpsw_lbl.Name = "chngpsw_lbl";
            this.chngpsw_lbl.Size = new System.Drawing.Size(268, 29);
            this.chngpsw_lbl.TabIndex = 7;
            this.chngpsw_lbl.Text = "Change Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.chngpsw_lbl);
            this.Controls.Add(this.chngpsw_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmpsw_lbl);
            this.Controls.Add(this.newpsw_lbl);
            this.Controls.Add(this.oldpsw_lbl);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldpsw_lbl;
        private System.Windows.Forms.Label newpsw_lbl;
        private System.Windows.Forms.Label confirmpsw_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button chngpsw_btn;
        private System.Windows.Forms.Label chngpsw_lbl;
    }
}