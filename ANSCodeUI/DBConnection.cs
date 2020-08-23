using System;
using System.Collections.Generic;
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
    }
}
