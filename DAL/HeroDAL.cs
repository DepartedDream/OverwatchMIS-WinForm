using System;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public static class HeroDAL
    {
        public static string GetHeroName(string heroNumber)
        {
            string sql = string.Format("select HeroName from Hero where HeroNumber='{0}'", heroNumber);
            return Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
        }


        public static DataSet GetHeroNumber(string heroType)
        {
            string sql = string.Format("select HeroNumber from Hero where HeroType ='{0}'", heroType);
            return SqlHelper.GetDataSet(CommandType.Text, sql);
        }


        public static bool AddHeroData(Hero h)
        {
            string sql = "insert into Hero values(@HeroNumber,@HeroName,@HeroType)";
            SqlParameter[] p = {
                               new SqlParameter("@HeroNumber",h.HeroNumber),
                               new SqlParameter("@HeroName",h.HeroName),
                               new SqlParameter("@HeroType",h.HeroType)
                               };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p) == 0 ? false : true;
        }


        public static bool DelHeroData(string heroName)
        {
            string sql = string.Format("select HeroNumber from Hero where HeroName='{0}'", heroName);
            string heroNumber = Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
            SqlParameter[] p = {
                               new SqlParameter("@HeroNumber",heroNumber)
                               };
            sql = "delete from Skill where HeroNumber=@HeroNumber";
            SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p);
            sql = "delete from Hero where HeroNumber=@HeroNumber";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p) == 0 ? false : true;
        }


    }
}
