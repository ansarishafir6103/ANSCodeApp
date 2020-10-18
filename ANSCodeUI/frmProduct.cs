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
    public partial class frmProduct : Form
    {
        string _msg = "Product";

        frmProductList _frmProductList;
        public frmProduct(frmProductList frmProductList)
        {
            InitializeComponent();
            _frmProductList = frmProductList;
        }

        public void LoadCategory()
        {
            cmbCategory.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                SqlCommand sqlCommand = new SqlCommand("select category from tblCategory", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    cmbCategory.Items.Add(sqlDataReader[0].ToString());
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        public void LoadBrand()
        {
            cmbBrand.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
            {
                SqlCommand sqlCommand = new SqlCommand("select brand from tblBrand", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    cmbBrand.Items.Add(sqlDataReader[0].ToString());
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        private void Clear()
        {
            txtProductCode.Text = "";
            txtBarcode.Text = "";
            txtDescription.Text = "";
            cmbBrand.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtPrice.Text = "";
            txtInitialQty.Text = "";
            txtProductCode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    string brandid = "", categoryid = "";

                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;

                    #region Select BrandId
                    string BQuery = @"select id from tblBrand where brand like @brand";
                    sqlConnection.Open(); 
                    sqlCommand = new SqlCommand(BQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@brand", SqlDbType.VarChar).Value = cmbBrand.Text;
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows) { brandid = sqlDataReader[0].ToString(); }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    #endregion

                    #region Select CategoryId
                    string CQuery = @"select id from tblcategory where category like @category";
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(CQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = cmbCategory.Text;
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows) { categoryid = sqlDataReader[0].ToString(); }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    #endregion

                    #region Insert Product
                    string PQuery = @"insert into tblProduct (pcode,barcode,pdesc,brandid,categoryid,price) values (@pcode,@barcode,@pdesc,@brandid,@categoryid,@price)";
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(PQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@pcode", txtProductCode.Text);
                    sqlCommand.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    sqlCommand.Parameters.AddWithValue("@pdesc", txtDescription.Text);

                    if (string.IsNullOrEmpty(brandid)) brandid = "0";
                    sqlCommand.Parameters.AddWithValue("@brandid",int.Parse(brandid));

                    if (string.IsNullOrEmpty(categoryid)) categoryid = "0";
                    sqlCommand.Parameters.AddWithValue("@categoryid", int.Parse(categoryid));

                    if (string.IsNullOrEmpty(txtPrice.Text.Trim())) txtPrice.Text = "0";
                    sqlCommand.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Trim()));


                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    #endregion

                    MessageBox.Show("Product has been successfully saved.", _msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    _frmProductList.LoadRecords();
                  }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    string brandid = "", categoryid = "";

                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;

                    #region Select BrandId
                    string BQuery = @"select id from tblBrand where brand like @brand";
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(BQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@brand", SqlDbType.VarChar).Value = cmbBrand.Text;
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows) { brandid = sqlDataReader[0].ToString(); }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    #endregion

                    #region Select CategoryId
                    string CQuery = @"select id from tblcategory where category like @category";
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(CQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = cmbCategory.Text;
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows) { categoryid = sqlDataReader[0].ToString(); }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    #endregion

                    #region Insert Product
                    string PQuery = @"update tblProduct set pcode=@pcode,barcode=@barcode,pdesc=@pdesc,brandid=@brandid,categoryid=@categoryid,price=@price where pcode like @pcode";
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(PQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@pcode", txtProductCode.Text);
                    sqlCommand.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    sqlCommand.Parameters.AddWithValue("@pdesc", txtDescription.Text);

                    if (string.IsNullOrEmpty(brandid)) brandid = "0";
                    sqlCommand.Parameters.AddWithValue("@brandid", int.Parse(brandid));

                    if (string.IsNullOrEmpty(categoryid)) categoryid = "0";
                    sqlCommand.Parameters.AddWithValue("@categoryid", int.Parse(categoryid));

                    if (string.IsNullOrEmpty(txtPrice.Text.Trim())) txtPrice.Text = "0";
                    sqlCommand.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Trim()));

                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    #endregion

                    MessageBox.Show("Product has been successfully updated.", _msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    _frmProductList.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 46)
                {
                    //accept . character
                }
                else if (e.KeyChar==8)
                {
                    //accept backspace
                }
                else if ((e.KeyChar < 48) || (e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), _msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
