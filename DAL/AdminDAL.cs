using System;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public static class AdminDAL
    {
        public static bool GetAdmin(Admin ad)
        {
            SqlParameter[] p = {
                             new SqlParameter("@UserName",ad.UserName),
                             new SqlParameter("@Password",ad.Password),
                             };
            string sql = "select * from  Administrator where UserName=@UserName and Password=@Password";
            return SqlHelper.ExecuteReader(CommandType.Text, sql, p).Read();
        }


    }
}
