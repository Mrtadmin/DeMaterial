using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class MaterUserdal
    {
        //查询用户信息
        public List<Model.MaterUser> user(string whereStr = null, int start = 1, int end = 20)
        {
            List<Model.MaterUser> materuser = new List<Model.MaterUser>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from [MaterUser] where [State]=0 " + whereStr);
                if (dr != null)
                {
                    Model.MaterUser user = null;
                    while (dr.Read())
                    {
                        user = new MaterUser();
                        user.Address = dr["Address"].ToString();
                        user.Password = dr["Password"].ToString();
                        user.State = (int)dr["State"];
                        user.UserAccout = dr["UserAccout"].ToString();
                        if (!string.IsNullOrEmpty(dr["UserBirthday"].ToString()))
                        {
                            user.UserBirthday = (DateTime)dr["UserBirthday"];
                        }
                        user.UserGender = dr["UserGender"].ToString();
                        user.UserID = dr["UserID"] as string;
                        user.UserName = dr["UserName"].ToString();
                        user.UserRemark=dr["UserRemark"].ToString();
                        materuser.Add(user);
                    }
                      
                    dr.Close();
                    SQLHelp.CloseConnection();
                }
            }
            return materuser;
        }
        /// <summary>
        /// 方法：获取用户的数量
        /// </summary>
        /// <returns>用户的数量</returns>
        public int GetMater()
        {
            return (int)SQLHelp.ExecScalar("select count(*) from [MaterUser]");
        }
        //添加用户信息
        public int InserMaterialUser(Model.MaterUser user)
        {
            return SQLHelp.ExecQuery("insert into [MaterUser]([UserName],[UserAccout],[Password]) values('"
                + user.UserName + "','" + user.UserAccout + "','" + user.Password + "')");
        }
        //修改用户信息
        public int UpdateMaterUser(Model.MaterUser mater)
        {
            string sql = "Update [MaterUser] set [Sate]=0";

            if (!string.IsNullOrEmpty(mater.UserName))
                sql += ",[UserName]='" + mater.UserName + "'";
            if (!string.IsNullOrEmpty(mater.UserAccout))
                sql += ",[UserAccout]='" + mater.UserAccout + "'";
            if (!string.IsNullOrEmpty(mater.Password))
                sql += "'[Password]='" + mater.Password + "'";
            if (mater.UserBirthday.Year > 1)
                sql += "'[UserBirthday]='" + mater.UserBirthday + "'";
            if (!string.IsNullOrEmpty(mater.UserGender))
                sql += "'[UserGender]='" + mater.UserGender + "'";
            if (!string.IsNullOrEmpty(mater.Address))
                sql += "'[Address]='" + mater.Address + "'";
            if (!string.IsNullOrEmpty(mater.UserRemark))
                sql += "'[UserRemark]='" + mater.UserRemark + "'";
            if (mater.State > 0)
                sql += "'[Sate]='" + mater.State + "'";

            sql += " where [UserID]='" + mater.UserID + "'";
            return SQLHelp.ExecQuery(sql);
        }
    }
}
