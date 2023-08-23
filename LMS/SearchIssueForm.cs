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
    public partial class SearchIssueForm : Form
    {
        LMSEntities context = new LMSEntities();
        public SearchIssueForm()
        {
            InitializeComponent();
            catcombo.DataSource = context.Categories.ToList();
            catcombo.DisplayMember = "Title";
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            resultgrid.AutoGenerateColumns = false;
            var books = context.Books.Where(x => x.Title == btitletxt.Text || x.Category == catcombo.Text).ToList(); 
            resultgrid.DataSource = books;
        }

        private void resultgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = resultgrid.Rows[e.RowIndex].Cells[2].Value;
            var Quantity = resultgrid.Rows[e.RowIndex].Cells[4].Value;
            var category = resultgrid.Rows[e.RowIndex].Cells[3].Value;
            var isbn = resultgrid.Rows[e.RowIndex].Cells[1].Value;
            bktitle_text.Text = title.ToString();
            avlbleqty_txt.Text = Quantity.ToString();
            bkctgry_text.Text = category.ToString();
            bkISBNnum_text.Text = isbn.ToString();
        }

        private void issuebk_btn_Click(object sender, EventArgs e)
        {
            IssueBook book = new IssueBook();
            book.Enrollment = stdntnum_text.Text;
            book.ISBN = bkISBNnum_text.Text;
            book.IssueReturn = true;
            var singlebook = context.Books.Where(x => x.ISBN == bkISBNnum_text.Text).FirstOrDefault();
            singlebook.Quantity -= 1;
            context.IssueBooks.Add(book);
            context.SaveChanges();

        }
    }
}
