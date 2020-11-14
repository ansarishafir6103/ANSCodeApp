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
    public partial class frmDiscount : Form
    {
        frmPOS _pOS;
        string _msg = "Discount From";
        public frmDiscount(frmPOS pOS)
        {
            InitializeComponent();
            _pOS = pOS;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDiscountPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(txtPrice.Text) * Double.Parse(txtDiscountPer.Text);
                txtDiscountAmount.Text = discount.ToString("#,##0.00");
            }
            catch (Exception)
            {

                txtDiscountAmount.Text = "0.00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Add Discount ?? Click yes to confirm",
                                      "Confirm!!",
                                      MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection  sqlConnection=new SqlConnection(DBConnection.MyConnection()))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("update tblCart set disc =@disc where id = @id ", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@disc",Double.Parse(txtDiscountAmount.Text));
                        sqlCommand.Parameters.AddWithValue("@id",int.Parse(lblID.Text));
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        _pOS.loadCart();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
