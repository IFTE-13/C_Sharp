using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WFADataBaseProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string sql = "select * from DemoTable where Id = '"+ this.txtUsername.Text + "' and Password = ' " + this.txtPassword.Text +"';";
            SqlConnection sqlCon = new SqlConnection("Data Source = IFTE_13\\IFTE_13; Initial Catalog = Demo; Persist Security Info = True; User ID = sa; Password = ifte1234");
            sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand("select * from DemoTable", sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            /*if(ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Confirmed");
            }
            else
            {
                MessageBox.Show("No user Found");
            }*/

            int index = 0;
            bool flag = false;
            while(index < ds.Tables[0].Rows.Count)
            {
                if (this.txtUsername.Text == ds.Tables[0].Rows[index][0].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[index][2].ToString())
                {
                    MessageBox.Show("Login Confirmed");
                    flag = true;
                    break;
                }
                index++;
            }

            if (!flag)
            {
                MessageBox.Show("No user Found");
            }

            sqlCon.Close(); // Date string sql uses for storing yyyy-mm-dd
        }
    }
}
