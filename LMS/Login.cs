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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lgn_btn_Click(object sender, EventArgs e)
        {
            LMSEntities content = new LMSEntities();
            if(usr_txtbox.Text != string.Empty && psw_txtbox.Text != string.Empty)
            {
                var user = content.LMSAdmins.Where(x => x.UserName.Equals(usr_txtbox.Text)).FirstOrDefault();
                if(user != null)
                {
                    if(user.Password.Equals(psw_txtbox.Text)) 
                    {
                        MessageBox.Show("Login");
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username Incorrect");
                }
            }
        }
    }
}
