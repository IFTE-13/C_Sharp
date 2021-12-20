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
    public partial class Admin : Form
    {
        private LoginForm LF {set; get;}
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string usersId, LoginForm lf) : this()
        {
            this.lblUser.Text += usersId;
            this.LF = lf;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged Out");
            this.LF.Show();
        }
    }
}
