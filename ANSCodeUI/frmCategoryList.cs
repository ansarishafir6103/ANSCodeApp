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
    public partial class frmCategoryList : Form
    {
        private string _msgHeader = "Form Brand List";
        public frmCategoryList()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                int i = 0;
                grvData.Rows.Clear();
                SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection());
                SqlCommand sqlCommand = new SqlCommand("select * from tblCategory order by category", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    i += 1;
                    grvData.Rows.Add
                        (i,
                        sqlDataReader["id"].ToString(),
                        sqlDataReader["category"].ToString()
                        );
                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory(this);
            category.btnSave.Enabled = true;
            category.btnUpdate.Enabled = true;
            category.ShowDialog();
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grvData.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmCategory category = new frmCategory(this);
                category.lblId.Text = grvData[1, e.RowIndex].Value.ToString();
                category.txtCategoryName.Text = grvData[2, e.RowIndex].Value.ToString();
                category.ShowDialog();
            }
            else if (colName == "Delete")
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    using (SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection()))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("delete from tblCategory where id like '" + grvData[1, e.RowIndex].Value.ToString() + "' ", sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Record deleted Succesfully", _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }

                }
                else
                {
                    // If 'No', do something here.
                }
            }
        }
    }
}
