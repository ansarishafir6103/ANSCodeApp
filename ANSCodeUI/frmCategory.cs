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
    public partial class frmCategory : Form
    {
        private string _msgHeader = "Form Category";
        frmCategoryList  _categoryList;
        public frmCategory(frmCategoryList categoryList)
        {
            InitializeComponent();
            _categoryList = categoryList;
        }

        #region Insert
        private void InsertCategory()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblCategory (category) values (@category)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@category",txtCategoryName.Text);
                    sqlCommand.ExecuteNonQuery();
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Update
        private void CategoryUpdate()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("update tblCategory set category=@category where id like @id ", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@id", lblId.Text);
                    sqlCommand.Parameters.AddWithValue("@category", txtCategoryName.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Record Updated Successfully", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtCategoryName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("category name is empty", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InsertCategory();
                funClear();
                _categoryList.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    CategoryUpdate();
                    funClear();
                    _categoryList.LoadData();
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
