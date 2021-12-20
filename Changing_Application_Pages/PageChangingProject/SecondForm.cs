using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageChangingProject
{
    public partial class SecondForm : Form
    {
        private FirstForm F1 { get; set; }
        public SecondForm()
        {
            InitializeComponent();
        }

        public SecondForm(string text, FirstForm f1)
        {
            InitializeComponent();
            this.lblInfo.Text = text;
            this.F1 = f1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.F1.Visible = true;
            this.Visible = false;
        }
    }
}
