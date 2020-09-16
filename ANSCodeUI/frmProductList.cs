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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct(this);
            product.btnSave.Enabled = true;
            product.btnUpdate.Enabled = false;
            product.LoadBrand();
            product.LoadCategory();
            product.ShowDialog();
        }
        public void LoadRecords()
        {
            grvData.Rows.Clear();
            using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
            {
                int i = 0;
                sqlConnection.Open();
                string query = @"select p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty from tblProduct as p
                                 inner join  tblBrand as b on b.id=p.brandid
                                    inner join tblCategory as c on c.id=p.categoryid where p.pdesc like '%" + txtSearch.Text +"%'";
                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    i++;
                    grvData.Rows.Add
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadRecords();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Product List",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = grvData.Columns[e.ColumnIndex].Name;
                if (colName=="Edit")
                {
                    frmProduct frmProduct = new frmProduct(this);
                    frmProduct.btnSave.Enabled = false;
                    frmProduct.btnUpdate.Enabled = true;
                    frmProduct.txtProductCode.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frmProduct.txtBarcode.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frmProduct.txtDescription.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    frmProduct.txtPrice.Text = grvData.Rows[e.RowIndex].Cells[6].Value.ToString();
                    frmProduct.cmbBrand.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                    frmProduct.cmbCategory.Text = grvData.Rows[e.RowIndex].Cells[5].Value.ToString();
                   // frmProduct.txtInitialQty.Text= grvData.Rows[e.RowIndex].Cells[5].Value.ToString();
                    frmProduct.ShowDialog();
                }
                else
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                        {
                            sqlConnection.Open();
                            string query = "delete from tblProduct where pcode like '" + grvData.Rows[e.RowIndex].Cells[1].Value.ToString() +"'";
                            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Product List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductList_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
