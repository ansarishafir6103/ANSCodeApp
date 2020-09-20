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
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }

        public void LoadProduct()
        {
            using (SqlConnection sqlConnection=new SqlConnection(DBConnection.MyConnection()))
            {
                sqlConnection.Open();
                int i = 0;
                string query = "select pcode,pdesc,price from tblProduct where pdesc like '%"+txtSearch.Text+"%' order by pdesc";
                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    i++;
                    grvData.Rows.Add
                        (i,
                        sqlDataReader[0].ToString(),
                        sqlDataReader[1].ToString(),
                        sqlDataReader[2].ToString()
                        );
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }
    }
}
