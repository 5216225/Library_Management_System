namespace LMS
{
    partial class Login
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
            this.usr_label = new System.Windows.Forms.Label();
            this.psw_label = new System.Windows.Forms.Label();
            this.usr_txtbox = new System.Windows.Forms.TextBox();
            this.psw_txtbox = new System.Windows.Forms.TextBox();
            this.lgn_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usr_label
            // 
            this.usr_label.AutoSize = true;
            this.usr_label.Location = new System.Drawing.Point(28, 81);
            this.usr_label.Name = "usr_label";
            this.usr_label.Size = new System.Drawing.Size(55, 13);
            this.usr_label.TabIndex = 0;
            this.usr_label.Text = "Username";
            // 
            // psw_label
            // 
            this.psw_label.AutoSize = true;
            this.psw_label.Location = new System.Drawing.Point(28, 125);
            this.psw_label.Name = "psw_label";
            this.psw_label.Size = new System.Drawing.Size(53, 13);
            this.psw_label.TabIndex = 1;
            this.psw_label.Text = "Password";
            // 
            // usr_txtbox
            // 
            this.usr_txtbox.Location = new System.Drawing.Point(89, 81);
            this.usr_txtbox.Name = "usr_txtbox";
            this.usr_txtbox.Size = new System.Drawing.Size(167, 20);
            this.usr_txtbox.TabIndex = 2;
            // 
            // psw_txtbox
            // 
            this.psw_txtbox.Location = new System.Drawing.Point(89, 122);
            this.psw_txtbox.Name = "psw_txtbox";
            this.psw_txtbox.PasswordChar = '*';
            this.psw_txtbox.Size = new System.Drawing.Size(167, 20);
            this.psw_txtbox.TabIndex = 3;
            // 
            // lgn_btn
            // 
            this.lgn_btn.Location = new System.Drawing.Point(69, 177);
            this.lgn_btn.Name = "lgn_btn";
            this.lgn_btn.Size = new System.Drawing.Size(132, 55);
            this.lgn_btn.TabIndex = 4;
            this.lgn_btn.Text = "Login";
            this.lgn_btn.UseVisualStyleBackColor = true;
            this.lgn_btn.Click += new System.EventHandler(this.lgn_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lgn_btn);
            this.Controls.Add(this.psw_txtbox);
            this.Controls.Add(this.usr_txtbox);
            this.Controls.Add(this.psw_label);
            this.Controls.Add(this.usr_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usr_label;
        private System.Windows.Forms.Label psw_label;
        private System.Windows.Forms.TextBox usr_txtbox;
        private System.Windows.Forms.TextBox psw_txtbox;
        private System.Windows.Forms.Button lgn_btn;
        private System.Windows.Forms.Label label1;
    }
}

