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
    public partial class frmLookUp : Form
    {
        string message = "lookup From";
        frmPOS _frm;
        public frmLookUp(frmPOS frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        public void LoadRecords()
        {
            grvData.Rows.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                int i = 0;
                sqlConnection.Open();
                string query = @"select p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty from tblProduct as p
                                 inner join  tblBrand as b on b.id=p.brandid
                                    inner join tblCategory as c on c.id=p.categoryid where p.pdesc like '%" + txtSearch.Text + "%'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,message,MessageBoxButtons.OK,MessageBoxIcon.Error);
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

                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            try
            {
                string colName = grvData.Columns[e.ColumnIndex].Name;
                if (colName=="Select")
                {
                    frmQty frm = new frmQty(_frm);
                    frm.productDetails(
                        grvData.Rows[e.RowIndex].Cells[1].Value.ToString(),
                       Convert.ToDouble(grvData.Rows[e.RowIndex].Cells[6].Value.ToString()),
                        _frm.lblTransactionNo.Text.Trim()
                        );
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
