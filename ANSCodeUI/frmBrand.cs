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
        public frmBrand()
        {
            InitializeComponent();
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
                    funClear();
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
                    SqlCommand sqlCommand = new SqlCommand("update tblBrand set brand='"+txtBrandName.Text+"' where id="+_identity+"", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@id", txtBrandName.Text);
                    sqlCommand.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    _identity = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Record Save Succesfully", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funClear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (_identity==0)
                {
                    InsertBrand();
                    return;
                }
                BrandUpdate();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #endregion
    }
}
