using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ANSCodeUI
{
    public partial class frmBrandList : Form
    {
        #region Variables
        private const string _msgHeader = "Barnd List Form";

        #endregion
        #region Constructors  
        #region frmBrandList
        public frmBrandList()
        {
            InitializeComponent();
            LoadData();
        }
        #endregion

        #endregion

        #region Methods

        public void LoadData()
        {
            try
            {
                int i = 0;
                grvData.Rows.Clear();
                SqlConnection sqlConnection = new SqlConnection(DBConnection.MyConnection());
                SqlCommand sqlCommand = new SqlCommand("select * from tblBrand order by brand",sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); 
                while(sqlDataReader.Read())
                {
                    i += 1;
                    grvData.Rows.Add
                        (i,
                        sqlDataReader["id"].ToString(),
                        sqlDataReader["brand"].ToString()
                        );
                }
                
                sqlConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events
        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand frmBrand = new frmBrand(this);
                frmBrand.ShowDialog();
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

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grvData.Columns[e.ColumnIndex].Name;
            if (colName=="Edit")
            {
                frmBrand Brand = new frmBrand(this);
                Brand.lblId.Text= grvData[1, e.RowIndex].Value.ToString();
                Brand.txtBrandName.Text = grvData[2,e.RowIndex].Value.ToString();
                Brand.ShowDialog();
            }
            else if(colName == "Delete")
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
                        SqlCommand sqlCommand = new SqlCommand("delete from tblBrand where id like '" + grvData[1,e.RowIndex].Value.ToString() + "' ", sqlConnection);
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
