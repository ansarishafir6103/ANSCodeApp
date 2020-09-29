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
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                sqlConnection.Open();
                int i = 0;
                string query = "select pcode,pdesc,price from tblProduct where pdesc like '%" + txtSearch.Text + "%' order by pdesc";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    i++;
                    grvData.Rows.Add
                        (i,
                        sqlDataReader[0].ToString(),
                        sqlDataReader[1].ToString(),
                        sqlDataReader[2].ToString()
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
                string query = "select * from View_StockIn where 1=1 or refno like '" + txtSearch.Text +"'";
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
                string colName = grvData.Columns[e.ColumnIndex].Name;
                if (colName == "colSelect")
                {

                    if (string.IsNullOrEmpty(txtRefNo.Text)) { MessageBox.Show("please enter reference no",_msg,MessageBoxButtons.OK,MessageBoxIcon.Warning); txtRefNo.Focus(); return; }
                    if (string.IsNullOrEmpty(txtStockInBy.Text)) { MessageBox.Show("please enter stock In by",_msg,MessageBoxButtons.OK,MessageBoxIcon.Warning); txtStockInBy.Focus(); return; }
                    var confirmResult = MessageBox.Show("Are you sure to add this item ??",
                                    "Confirm add!!",
                                    MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                        {
                            sqlConnection.Open();
                            string query = "insert into tblStockIn (refno,pcode,sdate,stockinby) values (@refno,@pcode,@sdate,@stockinby)";//select * from tblStockIn where pcode like '" + grvData.Rows[e.RowIndex].Cells[1].Value.ToString() +"'";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@refno", txtRefNo.Text);
                            sqlCommand.Parameters.AddWithValue("@pcode", grvData.Rows[e.RowIndex].Cells[1].Value.ToString());
                            sqlCommand.Parameters.AddWithValue("@sdate", dtpStockInDate.Value);
                            sqlCommand.Parameters.AddWithValue("@stockinby", txtStockInBy.Text);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            MessageBox.Show("successfully added!", _msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                        {
                            string query = @"delete from tblStockIn where id = '"+ grvDetail.Rows[e.RowIndex].Cells[1].Value.ToString() +"'";
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
    }
}
