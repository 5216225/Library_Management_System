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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            LMSEntities context = new LMSEntities();
            Category category = new Category();
            category.Title = newctgry_text.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("New Category Added");
        }

        private void rmv_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
