using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSCodeUI
{
    public partial class frmStockIn : Form
    {
        string _msg = "Stock In";
        public frmStockIn()
        {
            InitializeComponent();
        }

        public void LoadProduct()
        {
            grvDetail.Rows.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                int i = 0;
                sqlConnection.Open();
                string query = @"select p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty from tblProduct as p
                                 inner join  tblBrand as b on b.id=p.brandid
                                    inner join tblCategory as c on c.id=p.categoryid";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    i++;
                    grvDetail.Rows.Add
                        (
                        i,
                        sqlDataReader[0].ToString(),
                        sqlDataReader[1].ToString(),
                        sqlDataReader[2].ToString(),
                        sqlDataReader[3].ToString(),
                        sqlDataReader[4].ToString(),
                        sqlDataReader[5].ToString(),
                        sqlDataReader[6].ToString()
                        );
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        public void LoadStockIn()
        {
            grvDetail.Rows.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                sqlConnection.Open();
                int i = 0;
                string query = "select * from View_StockIn where refno like '" + txtRefNo.Text + "' and status like 'pending'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    i++;
                    grvDetail.Rows.Add
                        (i,
                        sqlDataReader[0].ToString(),
                        sqlDataReader[1].ToString(),
                        sqlDataReader[2].ToString(),
                        sqlDataReader[3].ToString(),
                        sqlDataReader[4].ToString(),
                        sqlDataReader[5].ToString(),
                        sqlDataReader[6].ToString()
                        );
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = grvDetail.Columns[e.ColumnIndex].Name;
                if (colName == "colDelete")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                    "Confirm delete!!",
                                    MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                        {
                            string query = @"delete from tblStockIn where id = '" + grvDetail.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            MessageBox.Show("Item has been successfully removed !", _msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStockIn();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            try
            {
                txtRefNo.Text = string.Empty;
                txtStockInBy.Text = string.Empty;
                dtpStockInDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDetail.Rows.Count > 0)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                    {
                        for (int i = 0; i < grvDetail.Rows.Count; i++)
                        {

                            SqlCommand sqlCommand = new SqlCommand();

                            //update tblProduct
                            string queryProduct = "update tblProduct set qty = qty + " + int.Parse(grvDetail.Rows[i].Cells[5].Value.ToString()) + " where pcode like '" + grvDetail.Rows[i].Cells[3].Value.ToString() + "'";
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand(queryProduct, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            //update tblStock
                            string queryStock = "update tblStockIn set qty = qty + " + int.Parse(grvDetail.Rows[i].Cells[5].Value.ToString()) + ", status = 'done' where id like '" + grvDetail.Rows[i].Cells[1].Value.ToString() + "' ";
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand(queryStock, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }
                    clear();
                    LoadStockIn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmSearchProductStockIn searchProductStockIn = new frmSearchProductStockIn(this);
                searchProductStockIn.LoadProduct();
                searchProductStockIn.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {

        }
    }
}
