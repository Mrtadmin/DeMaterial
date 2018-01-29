using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class Materialdal
    {
        //查询材料信息
        public List<Model.Material> Getmaterial(string whereStr = null, int start = 1, int end = 20)
        {
            List<Model.Material> mater = new List<Model.Material>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from [Material] where [State]=0 " +whereStr);
                if (dr != null)
                {
                    while(dr.Read())
                    {
                        mater.Add(new Model.Material()
                        {
                            MaterialID = (int)dr["MaterialID"],
                            MaterialName = dr["MaterialName"].ToString(),
                            ImageURL = dr["ImageURL"].ToString(),
                            Materialnum = (int)dr["Materialnum"],
                            MaterialPrice = (decimal)dr["MaterialPrice"],
                            MaterialTypeID = (int)dr["MaterialTypeID"],
                            Origin = dr["Origin"].ToString(),
                            Brand = dr["Brand"].ToString(),
                            Model = dr["Model"].ToString(),
                            specifications = dr["specifications"].ToString(),
                            Style = dr["Style"].ToString(),
                            level = dr["level"].ToString(),
                            PartsTypeID = (int)dr["PartsTypeID"],
                            State = (int)dr["State"],
                        });
                      
                    }
                    SQLHelp.CloseConnection();
                }             
            }
            return mater;
        }
        //添加材料的数量
        public int InsertMaterial(Model.Material material)
        {
            return SQLHelp.ExecQuery("insert into [MaterialName],[ImageURL],[Materialunm],[MaterialPrice],[MaterialTypeID],[Origin],[Brand],[Model],[specifications],[Style],[level],[PartsTypeID],[State]) values('"
                +material.MaterialID+"','"+material.MaterialName+"','"+material.ImageURL+"','"+material.Materialnum+"','"+material.MaterialPrice+"','"+material.MaterialTypeID+"','"+material.Origin+"','"+material.Brand+
                "','"+material.Model+"','"+material.specifications+"','"+material.Style+"','"+material.level+"','"+material.PartsTypeID+"','"+material.State+"',0,0)");
        }
        //更新材料信息
        public int UpdateMaterial(Model.Material maters)
        {
            string sql = "Update [Material] set [State]=0";
            if (!string.IsNullOrEmpty(maters.MaterialName))
                sql += ",[MaterialName]='" + maters.MaterialName + "'";
            if (!string.IsNullOrEmpty(maters.ImageURL))
                sql += ",[ImageURl]='" + maters.ImageURL + "'";
            if (maters.Materialnum>0)
                sql += ",[Materialunm]='" + maters.Materialnum + "'";
            if (maters.MaterialPrice > 0)
                sql += ",[MaterialPrice]='" + maters.MaterialPrice + "'";
            if (maters.MaterialTypeID > 0)
                sql += ",[MaterialTypeID]='" + maters.MaterialTypeID + "'";
            if (!string.IsNullOrEmpty(maters.Origin))
                sql += ",[Origin]='" + maters.Origin + "'";
            if (!string.IsNullOrEmpty(maters.Brand))
                sql += "'[Brand]=" + maters.Brand + "'";
            if (!string.IsNullOrEmpty(maters.Model))
                sql += "'[Model]=" + maters.Model + "'";
            if (!string.IsNullOrEmpty(maters.specifications))
                sql += "'[specifications]=" + maters.specifications + "'";
            if (!string.IsNullOrEmpty(maters.Style))
                sql += "'[Style]=" + maters.Style + "'";
            if (maters.PartsTypeID > 0)
                sql += "'[PartsTypeID]=" + maters.PartsTypeID + "'";
            if (maters.State > 0)
                sql += "'[State]=" + maters.State + "'";
            sql += "where [MaterialID]='" + maters.MaterialID + "'";
            return SQLHelp.ExecQuery(sql);
        }
        //删除材料信息
        public int DeleteMaterial(string id)
        {
            return SQLHelp.ExecQuery("update [Material] set[State]=1 where [MaterialID] in(" + id + ")");
        }
    }
}
