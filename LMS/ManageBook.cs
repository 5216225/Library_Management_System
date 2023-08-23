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
    public partial class ManageBook : Form
    {
        LMSEntities context = new LMS.LMSEntities();
        public ManageBook()
        {
            InitializeComponent();
            ctgry_combo.DataSource = context.Categories.ToList();
            ctgry_combo.DisplayMember = "Title";
        }

        private void addbk_btn_Click(object sender, EventArgs e)
        {
            LMSEntities context = new LMSEntities();
            Book book = new Book();
            book.ISBN = isbnum_text.Text;
            book.Title = bktitle_txt.Text;
            book.Category = ctgry_combo.SelectedText;
            book.Quantity = Convert.ToInt32(addqty_txt.Text);
            context.Books.Add(book);
            context.SaveChanges();

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            LMSEntities context = new LMSEntities();
            var book = context.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            var bookqty = book.Quantity - Convert.ToInt32(qtyremovetxt.Text);
            book.Quantity = bookqty;
            context.SaveChanges();
            MessageBox.Show($"Book {qtyremovetxt.Text} Removed");
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            LMSEntities context = new LMSEntities();
            var book = context.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            rtitletxt.Text = book.Title;
            rcattxt.Text = book.Category;
            aqtytxt.Text = Convert.ToString(book.Quantity);
            rtitletxt.ReadOnly = true;
            rcattxt.ReadOnly = true;
            aqtytxt.ReadOnly = true;
        }
    }
}
