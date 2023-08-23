namespace LMS
{
    partial class ManageCategory
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
            this.newctgry_lbl = new System.Windows.Forms.Label();
            this.newctgry_text = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.newctgrytitle_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rmve_ctgy_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rmv_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newctgry_lbl
            // 
            this.newctgry_lbl.AutoSize = true;
            this.newctgry_lbl.Location = new System.Drawing.Point(6, 54);
            this.newctgry_lbl.Name = "newctgry_lbl";
            this.newctgry_lbl.Size = new System.Drawing.Size(96, 13);
            this.newctgry_lbl.TabIndex = 0;
            this.newctgry_lbl.Text = "Add New Category";
            // 
            // newctgry_text
            // 
            this.newctgry_text.Location = new System.Drawing.Point(108, 51);
            this.newctgry_text.Name = "newctgry_text";
            this.newctgry_text.Size = new System.Drawing.Size(274, 20);
            this.newctgry_text.TabIndex = 1;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(132, 118);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(148, 50);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // newctgrytitle_lbl
            // 
            this.newctgrytitle_lbl.AutoSize = true;
            this.newctgrytitle_lbl.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newctgrytitle_lbl.Location = new System.Drawing.Point(49, 9);
            this.newctgrytitle_lbl.Name = "newctgrytitle_lbl";
            this.newctgrytitle_lbl.Size = new System.Drawing.Size(357, 49);
            this.newctgrytitle_lbl.TabIndex = 3;
            this.newctgrytitle_lbl.Text = "Manage Categories";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submit_btn);
            this.groupBox1.Controls.Add(this.newctgry_lbl);
            this.groupBox1.Controls.Add(this.newctgry_text);
            this.groupBox1.Location = new System.Drawing.Point(24, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rmv_btn);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.rmve_ctgy_lbl);
            this.groupBox2.Location = new System.Drawing.Point(24, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Categories";
            // 
            // rmve_ctgy_lbl
            // 
            this.rmve_ctgy_lbl.AutoSize = true;
            this.rmve_ctgy_lbl.Location = new System.Drawing.Point(6, 45);
            this.rmve_ctgy_lbl.Name = "rmve_ctgy_lbl";
            this.rmve_ctgy_lbl.Size = new System.Drawing.Size(92, 13);
            this.rmve_ctgy_lbl.TabIndex = 3;
            this.rmve_ctgy_lbl.Text = "Remove Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // rmv_btn
            // 
            this.rmv_btn.Location = new System.Drawing.Point(132, 84);
            this.rmv_btn.Name = "rmv_btn";
            this.rmv_btn.Size = new System.Drawing.Size(148, 50);
            this.rmv_btn.TabIndex = 5;
            this.rmv_btn.Text = "Remove";
            this.rmv_btn.UseVisualStyleBackColor = true;
            this.rmv_btn.Click += new System.EventHandler(this.rmv_btn_Click);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newctgrytitle_lbl);
            this.Name = "ManageCategory";
            this.Text = "Manage Category";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newctgry_lbl;
        private System.Windows.Forms.TextBox newctgry_text;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label newctgrytitle_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label rmve_ctgy_lbl;
        private System.Windows.Forms.Button rmv_btn;
    }
}