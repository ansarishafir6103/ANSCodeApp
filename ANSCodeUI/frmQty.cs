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
    public partial class frmQty : Form
    {
        frmPOS _pOS;

        private string pcode;
        private double price;
        private string transno;

        public frmQty(frmPOS pOS)
        {
            InitializeComponent();
            _pOS = pOS;
        }

        public void productDetails(string pcode,double price,string transno)
        {
            try
            {
                this.pcode = pcode;
                this.price = price;
                this.transno = transno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmQty_Load(object sender, EventArgs e)
        {
            try
            {
                txtQty.Text = "0";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar==13) && (!string.IsNullOrEmpty(txtQty.Text.Trim())))
            {
                using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                {
                    string query = "insert into tblCart (transno,pcode,price,qty,sdate) values (@transno,@pcode,@price,@qty,@sdate)";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@transno",transno);
                    sqlCommand.Parameters.AddWithValue("@pcode", pcode);
                    sqlCommand.Parameters.AddWithValue("@price",double.Parse(price.ToString()));
                    sqlCommand.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text.Trim()));
                    sqlCommand.Parameters.AddWithValue("@sdate", DateTime.Now);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    _pOS.txtSearchBarcode.Clear();
                    _pOS.txtSearchBarcode.Focus();
                    _pOS.loadCart();
                    this.Dispose();
                }
            }
        }
    }
}
