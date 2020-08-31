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
using System.Xml;

namespace ANSCodeUI
{
    public partial class frmBrand : Form
    {
        #region Variables
        private int _identity = 0;
        private const string _msgHeader = "Brand Entry Form";
        #endregion

        #region Constructors
        #region frmBrand
        frmBrandList _frmBrandList;
        public frmBrand(frmBrandList frmBrandList)
        {
            InitializeComponent();
            _frmBrandList = frmBrandList;
        }
        #endregion
        #endregion

        #region Methods
        
        #region Insert
        private void InsertBrand()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblBrand (brand) values (@brand)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    _identity = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Record Save Succesfully", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        // Do something.
                        MessageBox.Show("You cannot insert duplicate record", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        throw;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,_msgHeader,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Update
        private void BrandUpdate()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("update tblBrand set brand=@brand where id like @id ", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@id", lblId.Text);
                    sqlCommand.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    _identity = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Record Updated Succesfully", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        // Do something.
                        MessageBox.Show("You cannot update duplicate record", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        throw;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region funClear
        private void funClear()
        {
            try
            {
                _identity = 0;
                txtBrandName.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion

        #region Events

        #region btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtBrandName.Text))
                {
                    MessageBox.Show("brand name is empty", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InsertBrand();
                funClear();
                _frmBrandList.LoadData();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to update this item ??",
                                     "Confirm Update!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    BrandUpdate();
                    funClear();
                    _frmBrandList.LoadData();
                    this.Dispose();
                }
                else
                {
                    // If 'No', do something here.
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
