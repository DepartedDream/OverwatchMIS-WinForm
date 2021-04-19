using System;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public static class MapDAL
    {
        public static DataSet GetMapNumber(string mapType)
        {
            string sql = string.Format("select MapNumber from Map where MapType='{0}'", mapType);
            return SqlHelper.GetDataSet(CommandType.Text, sql);
        }


        public static string GetMapName(string mapNumber)
        {
            string sql = string.Format("select MapName from Map where MapNumber='{0}'", mapNumber);
            return Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
        }


        public static bool AddMapData(Map m)
        {
            string sql = "insert into Map values(@MapNumber,@MapName,@MapType)";
            SqlParameter[] p = {
                               new SqlParameter("@MapNumber",m.MapNumber),
                               new SqlParameter("@MapName",m.MapName),
                               new SqlParameter("@MapType",m.MapType)
                               };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p) == 0 ? false : true;
        }


        public static bool DelMapData(string mapName, string mapType)
        {
            string sql = string.Format("select MapNumber from Map where MapName='{0}' and MapType='{1}'", mapName, mapType);
            string mapNumber = Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
            SqlParameter[] p = {
                               new SqlParameter("@MapNumber",mapNumber)
                               };
            sql = "delete from Strategy where MapNumber=@MapNumber";
            SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p);
            sql = "delete from Map where MapNumber=@MapNumber";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p) == 0 ? false : true;
        }


    }
}
