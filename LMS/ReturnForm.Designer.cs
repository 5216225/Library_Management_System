namespace LMS
{
    partial class ReturnForm
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
            this.isbnum_lbl = new System.Windows.Forms.Label();
            this.stdntnum_lbl = new System.Windows.Forms.Label();
            this.isbnum_text = new System.Windows.Forms.TextBox();
            this.stdntnum_text = new System.Windows.Forms.TextBox();
            this.return_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isbnum_lbl
            // 
            this.isbnum_lbl.AutoSize = true;
            this.isbnum_lbl.Location = new System.Drawing.Point(5, 75);
            this.isbnum_lbl.Name = "isbnum_lbl";
            this.isbnum_lbl.Size = new System.Drawing.Size(100, 13);
            this.isbnum_lbl.TabIndex = 0;
            this.isbnum_lbl.Text = "Enter ISBN Number";
            // 
            // stdntnum_lbl
            // 
            this.stdntnum_lbl.AutoSize = true;
            this.stdntnum_lbl.Location = new System.Drawing.Point(5, 120);
            this.stdntnum_lbl.Name = "stdntnum_lbl";
            this.stdntnum_lbl.Size = new System.Drawing.Size(164, 13);
            this.stdntnum_lbl.TabIndex = 1;
            this.stdntnum_lbl.Text = "Enter Student Enrollment Number";
            // 
            // isbnum_text
            // 
            this.isbnum_text.Location = new System.Drawing.Point(111, 72);
            this.isbnum_text.Name = "isbnum_text";
            this.isbnum_text.Size = new System.Drawing.Size(152, 20);
            this.isbnum_text.TabIndex = 2;
            // 
            // stdntnum_text
            // 
            this.stdntnum_text.Location = new System.Drawing.Point(175, 117);
            this.stdntnum_text.Name = "stdntnum_text";
            this.stdntnum_text.Size = new System.Drawing.Size(138, 20);
            this.stdntnum_text.TabIndex = 3;
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(84, 160);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(166, 58);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Book Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Returns";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.stdntnum_text);
            this.Controls.Add(this.isbnum_text);
            this.Controls.Add(this.stdntnum_lbl);
            this.Controls.Add(this.isbnum_lbl);
            this.Name = "ReturnForm";
            this.Text = "Return Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbnum_lbl;
        private System.Windows.Forms.Label stdntnum_lbl;
        private System.Windows.Forms.TextBox isbnum_text;
        private System.Windows.Forms.TextBox stdntnum_text;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label label1;
    }
}