using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBook book = new ManageBook();
            book.MdiParent = this;
            book.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory category = new ManageCategory();
            category.MdiParent = this;
            category.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBook book = new ManageBook();
            book.MdiParent = this;
            book.Show();
        }

        private void removeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory category = new ManageCategory();
            category.MdiParent = this;
            category.Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchIssueForm issueBook = new SearchIssueForm();
            issueBook.MdiParent = this;
            issueBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm returnBook = new ReturnForm();
            returnBook.MdiParent = this;
            returnBook.Show();  
        }
    }
}
