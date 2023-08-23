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
    public partial class ReturnForm : Form
    {
        LMSEntities context = new LMSEntities();
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            var issuebookByStudent = context.IssueBooks.Where(x => x.ISBN == isbnum_text.Text && x.IssueReturn == true).FirstOrDefault();
            issuebookByStudent.IssueReturn = false;
            var book = context.Books.Where(x => x.ISBN == isbnum_text.Text).FirstOrDefault();
            book.Quantity += 1;
            context.SaveChanges();
            MessageBox.Show("Book Returned");
        }
    }
}
