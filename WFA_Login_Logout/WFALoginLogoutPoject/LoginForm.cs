using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginLogoutPoject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text.ToLower() == "ifte" && this.txtPassword.Text == "123")
            {
                this.Hide(); //this.Visible = false;
                MessageBox.Show("Login Valid");
                Admin h = new Admin(this.txtUserID.Text, this);
                h.Show(); //h.Visible = true;
            }
            else if (this.txtUserID.Text.ToLower() == "mariam" && this.txtPassword.Text == "123")
            {
                this.Hide(); //this.Visible = false;
                MessageBox.Show("Login Valid");
                Member m = new Member(this.txtUserID.Text, this);
                m.Show(); //h.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Invalid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Text = "";
        }
    }
}
