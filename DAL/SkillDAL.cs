using System;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public static class SkillDAL
    {
        public static string GetSkillName(string skillId)
        {
            string sql = string.Format("select SkillName from Skill where SkillId={0}", skillId);
            return Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
        }


        public static DataSet GetSkillId(string heroId)
        {
            string sql = string.Format("select SkillId from Skill where HeroId='{0}'", heroId);
            return SqlHelper.GetDataSet(CommandType.Text, sql);
        }


        public static string GetSkillDescribeBySkillId(string skillId)
        {
            string sql = string.Format("select SkillDescribe from Skill where SkillId={0}", skillId);
            SqlParameter[] p = { new SqlParameter("@SkillId", s.SkillId) };

            return Convert.ToString(SqlHelper.ExecuteScalar(CommandType.Text, sql));
        }


        public static bool AddSkillData(Skill s) 
        {
            string sql = "insert into Skill values(@SkillId,@SkillName,@SkillDescribe,@HeroId)";
            SqlParameter[] p = {
                               new SqlParameter("@SkillId",s.SkillId),
                               new SqlParameter("@SkillName",s.SkillName),
                               new SqlParameter("@SkillDescribe",s.SkillDescribe),
                               new SqlParameter("@HeroId",s.HeroId)
                               };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, p) == 0 ? false : true;
        }


        public static bool DelSkillData(string skillName) 
        {
            SqlParameter[] p = {new SqlParameter("@SkillName",skillName)};
            string sql = string.Format("delete from Skill where SkillName='{0}'", skillName);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,p) == 0 ? false : true;
        }


    }
}
