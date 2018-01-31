using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Admin.Classes;


namespace Admin
{
    public partial class Login
    {
        public DataSet ValidarLogin(string sUserName, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]{
                DBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUserName),
                DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sPassword)
            };
            return DBHelper.ExecuteDataSet("usp_Login_ValidarLogin", dbParams);
        }
    }
}