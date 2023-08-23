namespace LMS
{
    partial class ManageBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbk_btn = new System.Windows.Forms.Button();
            this.ctgry_combo = new System.Windows.Forms.ComboBox();
            this.addqty_txt = new System.Windows.Forms.TextBox();
            this.bktitle_txt = new System.Windows.Forms.TextBox();
            this.isbnum_text = new System.Windows.Forms.TextBox();
            this.qty_lbl = new System.Windows.Forms.Label();
            this.ctgry_lbl = new System.Windows.Forms.Label();
            this.bktitle_lbl = new System.Windows.Forms.Label();
            this.isbnum_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.srch_btn = new System.Windows.Forms.Button();
            this.rtitletxt = new System.Windows.Forms.TextBox();
            this.rcattxt = new System.Windows.Forms.TextBox();
            this.aqtytxt = new System.Windows.Forms.TextBox();
            this.qtyremovetxt = new System.Windows.Forms.TextBox();
            this.risbntxt = new System.Windows.Forms.TextBox();
            this.qtytoremove_lbl = new System.Windows.Forms.Label();
            this.availableqty_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.booktitle_lbl = new System.Windows.Forms.Label();
            this.isbnnum_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addbk_btn);
            this.groupBox1.Controls.Add(this.ctgry_combo);
            this.groupBox1.Controls.Add(this.addqty_txt);
            this.groupBox1.Controls.Add(this.bktitle_txt);
            this.groupBox1.Controls.Add(this.isbnum_text);
            this.groupBox1.Controls.Add(this.qty_lbl);
            this.groupBox1.Controls.Add(this.ctgry_lbl);
            this.groupBox1.Controls.Add(this.bktitle_lbl);
            this.groupBox1.Controls.Add(this.isbnum_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Books";
            // 
            // addbk_btn
            // 
            this.addbk_btn.Location = new System.Drawing.Point(126, 245);
            this.addbk_btn.Name = "addbk_btn";
            this.addbk_btn.Size = new System.Drawing.Size(164, 38);
            this.addbk_btn.TabIndex = 8;
            this.addbk_btn.Text = "Add New Book";
            this.addbk_btn.UseVisualStyleBackColor = true;
            this.addbk_btn.Click += new System.EventHandler(this.addbk_btn_Click);
            // 
            // ctgry_combo
            // 
            this.ctgry_combo.FormattingEnabled = true;
            this.ctgry_combo.Location = new System.Drawing.Point(149, 135);
            this.ctgry_combo.Name = "ctgry_combo";
            this.ctgry_combo.Size = new System.Drawing.Size(211, 21);
            this.ctgry_combo.TabIndex = 7;
            // 
            // addqty_txt
            // 
            this.addqty_txt.Location = new System.Drawing.Point(149, 187);
            this.addqty_txt.Name = "addqty_txt";
            this.addqty_txt.Size = new System.Drawing.Size(211, 20);
            this.addqty_txt.TabIndex = 6;
            // 
            // bktitle_txt
            // 
            this.bktitle_txt.Location = new System.Drawing.Point(149, 89);
            this.bktitle_txt.Name = "bktitle_txt";
            this.bktitle_txt.Size = new System.Drawing.Size(211, 20);
            this.bktitle_txt.TabIndex = 5;
            // 
            // isbnum_text
            // 
            this.isbnum_text.Location = new System.Drawing.Point(149, 42);
            this.isbnum_text.Name = "isbnum_text";
            this.isbnum_text.Size = new System.Drawing.Size(211, 20);
            this.isbnum_text.TabIndex = 4;
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.Location = new System.Drawing.Point(43, 194);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(46, 13);
            this.qty_lbl.TabIndex = 3;
            this.qty_lbl.Text = "Quantity";
            // 
            // ctgry_lbl
            // 
            this.ctgry_lbl.AutoSize = true;
            this.ctgry_lbl.Location = new System.Drawing.Point(43, 143);
            this.ctgry_lbl.Name = "ctgry_lbl";
            this.ctgry_lbl.Size = new System.Drawing.Size(49, 13);
            this.ctgry_lbl.TabIndex = 2;
            this.ctgry_lbl.Text = "Category";
            // 
            // bktitle_lbl
            // 
            this.bktitle_lbl.AutoSize = true;
            this.bktitle_lbl.Location = new System.Drawing.Point(43, 96);
            this.bktitle_lbl.Name = "bktitle_lbl";
            this.bktitle_lbl.Size = new System.Drawing.Size(55, 13);
            this.bktitle_lbl.TabIndex = 1;
            this.bktitle_lbl.Text = "Book Title";
            // 
            // isbnum_lbl
            // 
            this.isbnum_lbl.AutoSize = true;
            this.isbnum_lbl.Location = new System.Drawing.Point(43, 45);
            this.isbnum_lbl.Name = "isbnum_lbl";
            this.isbnum_lbl.Size = new System.Drawing.Size(100, 13);
            this.isbnum_lbl.TabIndex = 0;
            this.isbnum_lbl.Text = "Book ISBN Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remove_btn);
            this.groupBox2.Controls.Add(this.srch_btn);
            this.groupBox2.Controls.Add(this.rtitletxt);
            this.groupBox2.Controls.Add(this.rcattxt);
            this.groupBox2.Controls.Add(this.aqtytxt);
            this.groupBox2.Controls.Add(this.qtyremovetxt);
            this.groupBox2.Controls.Add(this.risbntxt);
            this.groupBox2.Controls.Add(this.qtytoremove_lbl);
            this.groupBox2.Controls.Add(this.availableqty_lbl);
            this.groupBox2.Controls.Add(this.category_lbl);
            this.groupBox2.Controls.Add(this.booktitle_lbl);
            this.groupBox2.Controls.Add(this.isbnnum_lbl);
            this.groupBox2.Location = new System.Drawing.Point(420, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Books";
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(378, 142);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(88, 37);
            this.remove_btn.TabIndex = 11;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // srch_btn
            // 
            this.srch_btn.Location = new System.Drawing.Point(378, 30);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(88, 37);
            this.srch_btn.TabIndex = 10;
            this.srch_btn.Text = "Search";
            this.srch_btn.UseVisualStyleBackColor = true;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // rtitletxt
            // 
            this.rtitletxt.Location = new System.Drawing.Point(161, 95);
            this.rtitletxt.Name = "rtitletxt";
            this.rtitletxt.Size = new System.Drawing.Size(197, 20);
            this.rtitletxt.TabIndex = 9;
            // 
            // rcattxt
            // 
            this.rcattxt.Location = new System.Drawing.Point(161, 142);
            this.rcattxt.Name = "rcattxt";
            this.rcattxt.Size = new System.Drawing.Size(197, 20);
            this.rcattxt.TabIndex = 8;
            // 
            // aqtytxt
            // 
            this.aqtytxt.Location = new System.Drawing.Point(161, 191);
            this.aqtytxt.Name = "aqtytxt";
            this.aqtytxt.Size = new System.Drawing.Size(197, 20);
            this.aqtytxt.TabIndex = 7;
            // 
            // qtyremovetxt
            // 
            this.qtyremovetxt.Location = new System.Drawing.Point(161, 248);
            this.qtyremovetxt.Name = "qtyremovetxt";
            this.qtyremovetxt.Size = new System.Drawing.Size(197, 20);
            this.qtyremovetxt.TabIndex = 6;
            // 
            // risbntxt
            // 
            this.risbntxt.Location = new System.Drawing.Point(161, 39);
            this.risbntxt.Name = "risbntxt";
            this.risbntxt.Size = new System.Drawing.Size(197, 20);
            this.risbntxt.TabIndex = 5;
            // 
            // qtytoremove_lbl
            // 
            this.qtytoremove_lbl.AutoSize = true;
            this.qtytoremove_lbl.Location = new System.Drawing.Point(28, 251);
            this.qtytoremove_lbl.Name = "qtytoremove_lbl";
            this.qtytoremove_lbl.Size = new System.Drawing.Size(127, 13);
            this.qtytoremove_lbl.TabIndex = 4;
            this.qtytoremove_lbl.Text = "Quantity To Be Removed";
            // 
            // availableqty_lbl
            // 
            this.availableqty_lbl.AutoSize = true;
            this.availableqty_lbl.Location = new System.Drawing.Point(28, 198);
            this.availableqty_lbl.Name = "availableqty_lbl";
            this.availableqty_lbl.Size = new System.Drawing.Size(92, 13);
            this.availableqty_lbl.TabIndex = 3;
            this.availableqty_lbl.Text = "Available Quantity";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Location = new System.Drawing.Point(28, 149);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(49, 13);
            this.category_lbl.TabIndex = 2;
            this.category_lbl.Text = "Category";
            // 
            // booktitle_lbl
            // 
            this.booktitle_lbl.AutoSize = true;
            this.booktitle_lbl.Location = new System.Drawing.Point(28, 95);
            this.booktitle_lbl.Name = "booktitle_lbl";
            this.booktitle_lbl.Size = new System.Drawing.Size(55, 13);
            this.booktitle_lbl.TabIndex = 1;
            this.booktitle_lbl.Text = "Book Title";
            // 
            // isbnnum_lbl
            // 
            this.isbnnum_lbl.AutoSize = true;
            this.isbnnum_lbl.Location = new System.Drawing.Point(28, 42);
            this.isbnnum_lbl.Name = "isbnnum_lbl";
            this.isbnnum_lbl.Size = new System.Drawing.Size(100, 13);
            this.isbnnum_lbl.TabIndex = 0;
            this.isbnnum_lbl.Text = "Book ISBN Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Books";
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageBook";
            this.Text = "Manage Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ctgry_lbl;
        private System.Windows.Forms.Label bktitle_lbl;
        private System.Windows.Forms.Label isbnum_lbl;
        private System.Windows.Forms.ComboBox ctgry_combo;
        private System.Windows.Forms.TextBox addqty_txt;
        private System.Windows.Forms.TextBox bktitle_txt;
        private System.Windows.Forms.TextBox isbnum_text;
        private System.Windows.Forms.Label qty_lbl;
        private System.Windows.Forms.Button addbk_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rtitletxt;
        private System.Windows.Forms.TextBox rcattxt;
        private System.Windows.Forms.TextBox aqtytxt;
        private System.Windows.Forms.TextBox qtyremovetxt;
        private System.Windows.Forms.TextBox risbntxt;
        private System.Windows.Forms.Label qtytoremove_lbl;
        private System.Windows.Forms.Label availableqty_lbl;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.Label booktitle_lbl;
        private System.Windows.Forms.Label isbnnum_lbl;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.Label label1;
    }
}