namespace LMS
{
    partial class SearchIssueForm
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
            this.srch_btn = new System.Windows.Forms.Button();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.btitletxt = new System.Windows.Forms.TextBox();
            this.book_ctgry = new System.Windows.Forms.Label();
            this.booktitle_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultgrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bkISBNnum_text = new System.Windows.Forms.TextBox();
            this.bkISBNnum_lbl = new System.Windows.Forms.Label();
            this.issuebk_btn = new System.Windows.Forms.Button();
            this.avlbleqty_txt = new System.Windows.Forms.TextBox();
            this.bkctgry_text = new System.Windows.Forms.TextBox();
            this.stdntnum_text = new System.Windows.Forms.TextBox();
            this.bktitle_text = new System.Windows.Forms.TextBox();
            this.stdntnum_lbl = new System.Windows.Forms.Label();
            this.bkctgry_lbl = new System.Windows.Forms.Label();
            this.avlbeqty_lbl = new System.Windows.Forms.Label();
            this.bktitle_lbl = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srch_btn);
            this.groupBox1.Controls.Add(this.catcombo);
            this.groupBox1.Controls.Add(this.btitletxt);
            this.groupBox1.Controls.Add(this.book_ctgry);
            this.groupBox1.Controls.Add(this.booktitle_lbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria - Enter At Least One";
            // 
            // srch_btn
            // 
            this.srch_btn.Location = new System.Drawing.Point(242, 157);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(118, 42);
            this.srch_btn.TabIndex = 4;
            this.srch_btn.Text = "Search";
            this.srch_btn.UseVisualStyleBackColor = true;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // catcombo
            // 
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(90, 55);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(145, 21);
            this.catcombo.TabIndex = 3;
            // 
            // btitletxt
            // 
            this.btitletxt.Location = new System.Drawing.Point(69, 29);
            this.btitletxt.Name = "btitletxt";
            this.btitletxt.Size = new System.Drawing.Size(146, 20);
            this.btitletxt.TabIndex = 2;
            // 
            // book_ctgry
            // 
            this.book_ctgry.AutoSize = true;
            this.book_ctgry.Location = new System.Drawing.Point(7, 60);
            this.book_ctgry.Name = "book_ctgry";
            this.book_ctgry.Size = new System.Drawing.Size(77, 13);
            this.book_ctgry.TabIndex = 1;
            this.book_ctgry.Text = "Book Category";
            // 
            // booktitle_lbl
            // 
            this.booktitle_lbl.AutoSize = true;
            this.booktitle_lbl.Location = new System.Drawing.Point(7, 29);
            this.booktitle_lbl.Name = "booktitle_lbl";
            this.booktitle_lbl.Size = new System.Drawing.Size(55, 13);
            this.booktitle_lbl.TabIndex = 0;
            this.booktitle_lbl.Text = "Book Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultgrid);
            this.groupBox2.Location = new System.Drawing.Point(443, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // resultgrid
            // 
            this.resultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ISBN,
            this.Title,
            this.Category,
            this.Quantity});
            this.resultgrid.Location = new System.Drawing.Point(6, 19);
            this.resultgrid.Name = "resultgrid";
            this.resultgrid.Size = new System.Drawing.Size(738, 339);
            this.resultgrid.TabIndex = 0;
            this.resultgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bkISBNnum_text);
            this.groupBox3.Controls.Add(this.bkISBNnum_lbl);
            this.groupBox3.Controls.Add(this.issuebk_btn);
            this.groupBox3.Controls.Add(this.avlbleqty_txt);
            this.groupBox3.Controls.Add(this.bkctgry_text);
            this.groupBox3.Controls.Add(this.stdntnum_text);
            this.groupBox3.Controls.Add(this.bktitle_text);
            this.groupBox3.Controls.Add(this.stdntnum_lbl);
            this.groupBox3.Controls.Add(this.bkctgry_lbl);
            this.groupBox3.Controls.Add(this.avlbeqty_lbl);
            this.groupBox3.Controls.Add(this.bktitle_lbl);
            this.groupBox3.Location = new System.Drawing.Point(13, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1174, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue Book";
            // 
            // bkISBNnum_text
            // 
            this.bkISBNnum_text.Location = new System.Drawing.Point(437, 117);
            this.bkISBNnum_text.Name = "bkISBNnum_text";
            this.bkISBNnum_text.Size = new System.Drawing.Size(183, 20);
            this.bkISBNnum_text.TabIndex = 12;
            // 
            // bkISBNnum_lbl
            // 
            this.bkISBNnum_lbl.AutoSize = true;
            this.bkISBNnum_lbl.Location = new System.Drawing.Point(331, 120);
            this.bkISBNnum_lbl.Name = "bkISBNnum_lbl";
            this.bkISBNnum_lbl.Size = new System.Drawing.Size(100, 13);
            this.bkISBNnum_lbl.TabIndex = 11;
            this.bkISBNnum_lbl.Text = "Book ISBN Number";
            // 
            // issuebk_btn
            // 
            this.issuebk_btn.Location = new System.Drawing.Point(334, 193);
            this.issuebk_btn.Name = "issuebk_btn";
            this.issuebk_btn.Size = new System.Drawing.Size(276, 67);
            this.issuebk_btn.TabIndex = 10;
            this.issuebk_btn.Text = "Issue Book";
            this.issuebk_btn.UseVisualStyleBackColor = true;
            this.issuebk_btn.Click += new System.EventHandler(this.issuebk_btn_Click);
            // 
            // avlbleqty_txt
            // 
            this.avlbleqty_txt.Location = new System.Drawing.Point(105, 92);
            this.avlbleqty_txt.Name = "avlbleqty_txt";
            this.avlbleqty_txt.Size = new System.Drawing.Size(183, 20);
            this.avlbleqty_txt.TabIndex = 8;
            // 
            // bkctgry_text
            // 
            this.bkctgry_text.Location = new System.Drawing.Point(90, 138);
            this.bkctgry_text.Name = "bkctgry_text";
            this.bkctgry_text.Size = new System.Drawing.Size(183, 20);
            this.bkctgry_text.TabIndex = 7;
            // 
            // stdntnum_text
            // 
            this.stdntnum_text.Location = new System.Drawing.Point(473, 48);
            this.stdntnum_text.Name = "stdntnum_text";
            this.stdntnum_text.Size = new System.Drawing.Size(183, 20);
            this.stdntnum_text.TabIndex = 6;
            // 
            // bktitle_text
            // 
            this.bktitle_text.Location = new System.Drawing.Point(67, 48);
            this.bktitle_text.Name = "bktitle_text";
            this.bktitle_text.Size = new System.Drawing.Size(183, 20);
            this.bktitle_text.TabIndex = 5;
            // 
            // stdntnum_lbl
            // 
            this.stdntnum_lbl.AutoSize = true;
            this.stdntnum_lbl.Location = new System.Drawing.Point(331, 51);
            this.stdntnum_lbl.Name = "stdntnum_lbl";
            this.stdntnum_lbl.Size = new System.Drawing.Size(136, 13);
            this.stdntnum_lbl.TabIndex = 4;
            this.stdntnum_lbl.Text = "Student Enrollment Number";
            // 
            // bkctgry_lbl
            // 
            this.bkctgry_lbl.AutoSize = true;
            this.bkctgry_lbl.Location = new System.Drawing.Point(7, 141);
            this.bkctgry_lbl.Name = "bkctgry_lbl";
            this.bkctgry_lbl.Size = new System.Drawing.Size(77, 13);
            this.bkctgry_lbl.TabIndex = 3;
            this.bkctgry_lbl.Text = "Book Category";
            // 
            // avlbeqty_lbl
            // 
            this.avlbeqty_lbl.AutoSize = true;
            this.avlbeqty_lbl.Location = new System.Drawing.Point(7, 95);
            this.avlbeqty_lbl.Name = "avlbeqty_lbl";
            this.avlbeqty_lbl.Size = new System.Drawing.Size(92, 13);
            this.avlbeqty_lbl.TabIndex = 2;
            this.avlbeqty_lbl.Text = "Available Quantity";
            // 
            // bktitle_lbl
            // 
            this.bktitle_lbl.AutoSize = true;
            this.bktitle_lbl.Location = new System.Drawing.Point(6, 51);
            this.bktitle_lbl.Name = "bktitle_lbl";
            this.bktitle_lbl.Size = new System.Drawing.Size(55, 13);
            this.bktitle_lbl.TabIndex = 0;
            this.bktitle_lbl.Text = "Book Title";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // SearchIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 770);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchIssueForm";
            this.Text = "Search Issue Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label booktitle_lbl;
        private System.Windows.Forms.ComboBox catcombo;
        private System.Windows.Forms.TextBox btitletxt;
        private System.Windows.Forms.Label book_ctgry;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView resultgrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label stdntnum_lbl;
        private System.Windows.Forms.Label bkctgry_lbl;
        private System.Windows.Forms.Label avlbeqty_lbl;
        private System.Windows.Forms.Label bktitle_lbl;
        private System.Windows.Forms.TextBox bktitle_text;
        private System.Windows.Forms.TextBox avlbleqty_txt;
        private System.Windows.Forms.TextBox bkctgry_text;
        private System.Windows.Forms.TextBox stdntnum_text;
        private System.Windows.Forms.Button issuebk_btn;
        private System.Windows.Forms.TextBox bkISBNnum_text;
        private System.Windows.Forms.Label bkISBNnum_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}