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
    public partial class frmSearchProductStockIn : Form
    {
        string _msg = "Search Product Stock In";
        frmStockIn _stockIn;
        public frmSearchProductStockIn(frmStockIn stockIn)
        {
            InitializeComponent();
            _stockIn = stockIn;
        }
        //public void LoadProduct()
        //{
        //    grvData.Rows.Clear();
        //    using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
        //    {
        //        int i = 0;
        //        sqlConnection.Open();
        //        string query = @"select p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty from tblProduct as p
        //                         inner join  tblBrand as b on b.id=p.brandid
        //                            inner join tblCategory as c on c.id=p.categoryid where p.pdesc like '%" + txtSearch.Text + "%'";
        //        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            i++;
        //            grvData.Rows.Add
        //                (
        //                i,
        //                sqlDataReader[0].ToString(),
        //                sqlDataReader[1].ToString(),
        //                sqlDataReader[2].ToString(),
        //                sqlDataReader[3].ToString(),
        //                sqlDataReader[4].ToString(),
        //                sqlDataReader[5].ToString(),
        //                sqlDataReader[6].ToString()
        //                );
        //        }
        //        sqlDataReader.Close();
        //        sqlConnection.Close();
        //    }
        //}

        public void LoadProduct()
        {
            grvData.Rows.Clear();
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

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = grvData.Columns[e.ColumnIndex].Name;
                if (colName == "colSelect")
                {

                    if (string.IsNullOrEmpty(_stockIn.txtRefNo.Text)) { MessageBox.Show("please enter reference no", _msg, MessageBoxButtons.OK, MessageBoxIcon.Warning); _stockIn.txtRefNo.Focus(); return; }
                    if (string.IsNullOrEmpty(_stockIn.txtStockInBy.Text)) { MessageBox.Show("please enter stock In by", _msg, MessageBoxButtons.OK, MessageBoxIcon.Warning); _stockIn.txtStockInBy.Focus(); return; }
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
                            sqlCommand.Parameters.AddWithValue("@refno", _stockIn.txtRefNo.Text);
                            sqlCommand.Parameters.AddWithValue("@pcode", grvData.Rows[e.RowIndex].Cells[1].Value.ToString());
                            sqlCommand.Parameters.AddWithValue("@sdate", _stockIn.dtpStockInDate.Value);
                            sqlCommand.Parameters.AddWithValue("@stockinby", _stockIn.txtStockInBy.Text);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            MessageBox.Show("successfully added!", _msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _stockIn.LoadStockIn();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,_msg,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProduct();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Product List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Product List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
