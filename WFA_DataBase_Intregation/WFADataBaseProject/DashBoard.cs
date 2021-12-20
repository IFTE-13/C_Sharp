using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADataBaseProject
{
    public partial class DashBoard : Form
    {
        private DataAccess Da {get; set;}
        public DashBoard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Movie;";
            //this.PopulateGridView(sql);
            AutoIdGenerator();
        }

        private void PopulateGridView(string sql = "select * from Movie;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Movie where Genre = '"+ this.txtSearch.Text +"';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Movie where title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.IsValidToSave())
            {
                MessageBox.Show("Missing Data");
                return;
            }
            try
            {
                var qur = "select * from Movie where Id = '" + this.txtID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(qur);
                if (dt.Rows.Count == 1)
                {
                    var sql = @"update Movie
                              set  Title = '"+this.txtTitle.Text+ @"',
                                   Income = '" + this.txtIncome.Text + @"',
                                   IMDB = '" + this.txtIMDB.Text + @"',
                                   ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                   Genre = '" + this.cmbGenre.Text + @"'
                                   where Id = '" + this.txtID.Text + "';";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Updated");
                        this.ClearContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                else
                {
                    string sql = "insert into Movie values ('" + this.txtID.Text + "', '" + this.txtTitle.Text + "', " +
                                        this.txtIncome.Text + ", " + this.txtIMDB.Text + ", '" + this.dtpReleaseDate.Text + "', '" +
                                        this.cmbGenre.Text + "');";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Inserted");
                        this.ClearContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                
                this.PopulateGridView();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrWhiteSpace(this.txtID.Text) ||
               String.IsNullOrEmpty(this.txtTitle.Text) || String.IsNullOrWhiteSpace(this.txtTitle.Text) ||
               String.IsNullOrEmpty(this.txtIncome.Text) || String.IsNullOrWhiteSpace(this.txtIncome.Text) ||
               String.IsNullOrEmpty(this.txtIMDB.Text) || String.IsNullOrWhiteSpace(this.txtIMDB.Text) ||
               String.IsNullOrEmpty(this.cmbGenre.Text) || String.IsNullOrWhiteSpace(this.cmbGenre.Text)
               )
            {
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtTitle.Clear();
            this.txtIncome.Clear();
            this.txtIMDB.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;

            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();
            this.dgvMovie.ClearSelection();

            AutoIdGenerator();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMovie.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            var id = this.dgvMovie.CurrentRow.Cells["Id"].Value.ToString();
            var title = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();
            try 
            { 
                var sql = "delete from Movie where Id = '" + id + "';";
                int count = this.Da.ExecutiveDMLQuery(sql);

                if (count == 1)
                {
                   MessageBox.Show(title + " Removed");
                }
                else
                {
                   MessageBox.Show("Operation Failed");
                }

               this.PopulateGridView();
               this.ClearContent();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.dgvMovie.ClearSelection();
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dgvMovie.CurrentRow.Cells["Id"].Value.ToString();
            this.txtTitle.Text = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["IMDB"].Value.ToString();
            this.txtIncome.Text = this.dgvMovie.CurrentRow.Cells["Income"].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["Genre"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells["ReleaseDate"].Value.ToString();
        }

        private void AutoIdGenerator()
        {
            var sql = "select Id from Movie order by Id desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["Id"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "M-" + (++temp).ToString("d3");
            this.txtID.Text = newId;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
