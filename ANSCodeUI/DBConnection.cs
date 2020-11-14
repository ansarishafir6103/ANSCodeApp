using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSCodeUI
{
   public class DBConnection
    {
        public static string MyConnection()
        {
            string con = @"Data Source=DESKTOP-ITRE6AL\SQLEXPRESS;Initial Catalog=ANSCode;User ID=sa;Password=123";
            return con;
        }
        public static double GetVal()
        {
            try
            {
                double vat = 0;
                using (SqlConnection sqlConnection=new SqlConnection(MyConnection()))
                {
                    
                    string query = "select * from tblVat";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            vat = double.Parse(sqlDataReader["vat"].ToString());
                        }
                        sqlDataReader.Close();
                    }
                    sqlConnection.Close();
                   
                }
                return vat;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
