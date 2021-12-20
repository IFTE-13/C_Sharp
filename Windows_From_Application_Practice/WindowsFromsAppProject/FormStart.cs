using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsAppProject
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsernameOutput.Text = "";
            this.lblPassword.Text = "oPassword";
            this.lblDateOFBirth.Text = "oDate of Birth";
            this.lblProgram.Text = "oProgram";
            this.lblDepartment.Text = "oDepartment";
            this.pnlPriview.Visible = false;
            this.pnlInfo.Visible = true; 

            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbDepartment.SelectedIndex = -1;
            this.dtpDateOFBirth.Text = "";
            this.rbtnGrad.Checked = false;
            this.rbtnUnderGrad.Checked = false;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            this.pnlPriview.Visible = true;
            this.pnlInfo.Visible = false;
            this.txtUsernameOutput.Text = this.txtUsername.Text;
            this.lblPassword.Text = this.txtPassword.Text;
            this.lblDepartment.Text = this.cmbDepartment.Text;
            this.lblDateOFBirth.Text = this.dtpDateOFBirth.Text;
            if (this.rbtnUnderGrad.Checked)
                this.lblProgram.Text = "Bachelors";
            else if (this.rbtnGrad.Checked)
                this.lblProgram.Text = "Masters";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
