using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ANSCodeUI
{
    public partial class frmPOS : Form
    {
        string message = "POS From";
        string Id = "";
        string Price="";
        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            this.KeyPreview = true;
        }
        private void GetTransactionNo()
        {
            try
            {
                using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                {
                    string sdate = DateTime.Now.ToString("yyyyMMdd");
                    string transactionNo;
                    int count;
                    sqlConnection.Open();
                    string query = "select top 1 transno from tblCart where transno like '%"+ sdate + "%' order by id desc";
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    { transactionNo = sqlDataReader[0].ToString();
                        count =int.Parse( transactionNo.Substring(8,4));
                        lblTransactionNo.Text = sdate + (count + 1);
                    }
                    else { transactionNo = sdate + "1001";
                        lblTransactionNo.Text = transactionNo;
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                GetTransactionNo();
                txtSearchBarcode.Enabled = true;
                txtSearchBarcode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetCartTotal()
        {
            try
            {
                double discount = Double.Parse(lblDiscount.Text);
                double sales = double.Parse(lblSalesTotal.Text);
                double vat = sales * DBConnection.GetVal();
                double vatable = sales-vat;
                lblVat.Text = vat.ToString("#,##0.00");
                lblVatable.Text = vatable.ToString("#,##0.00");
                 lblDisplayTotal.Text= sales.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchBarcode.Text.Trim())) { return; }
                else
                {
                    using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                    {
                        string query = "select * from tblProduct where barcode like '" + txtSearchBarcode.Text.Trim() + "' ";
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        sqlDataReader.Read();
                        if (sqlDataReader.HasRows)
                        {
                            frmQty frm = new frmQty(this);
                            frm.productDetails(
                                sqlDataReader["pcode"].ToString(),
                                double.Parse(sqlDataReader["price"].ToString()),
                                lblTransactionNo.Text.Trim()
                                );
                            frm.ShowDialog();

                        }
                        sqlDataReader.Close();
                        sqlConnection.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadCart()
        {
            try
            {
                grvData.Rows.Clear();
                using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                {
                    string query = @"select c.id,c.pcode,p.pdesc,c.price,c.qty ,c.disc,c.total from tblCart as c
                                     inner join tblProduct as p on c.pcode = p.pcode where transno like '"+ lblTransactionNo.Text.Trim() +"' ";
                    int i = 0;
                    double total = 0,discount=0;
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            i++;
                            total += double.Parse(sqlDataReader["total"].ToString());
                            discount += Double.Parse(sqlDataReader["disc"].ToString());
                            grvData.Rows.Add(
                                i,
                                sqlDataReader["id"].ToString(),
                                sqlDataReader["pdesc"].ToString(),
                                sqlDataReader["price"].ToString(),
                                sqlDataReader["qty"].ToString(),
                                sqlDataReader["disc"].ToString(),
                                Double.Parse(sqlDataReader["total"].ToString()).ToString("#,##0.00")
                                );
                        }
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    lblSalesTotal.Text =total.ToString("#,##0.00");
                    lblDiscount.Text = discount.ToString("#,##0.00");
                    GetCartTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTransactionNo.Text.Trim()== "000000000000000") {return;}
                frmLookUp frm = new frmLookUp(this);
                frm.LoadRecords();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = grvData.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                        {
                            sqlConnection.Open();
                            string query = "delete from tblCart where id like '" + grvData.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            MessageBox.Show("delete success", message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadCart();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                frmDiscount frm = new frmDiscount(this);
                frm.lblID.Text = Id;
                frm.txtPrice.Text = Price;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = grvData.CurrentRow.Index;
                Id = grvData[1, i].Value.ToString();
                Price = grvData[3, i].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
