using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class MaterialTypedll
    {
        //查询材料类型信息
        public List<Model.MaterialType> GetMaterialType(string where = null)
        {
            List<Model.MaterialType> materialType = new List<MaterialType>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select mater.* from Material mater left join  MaterialType t on mater.MaterialTypeID=t.MaterialTypeID" + where);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        materialType.Add(new MaterialType()
                            {
                                MaterialTypeID = (int)dr["MaterialTypeID"],
                                TypeName = dr["TypeName"].ToString(),
                                Desc = dr["Desc"].ToString(),
                                State = (int)dr["Sate"],
                            });

                        dr.Close();
                        SQLHelp.CloseConnection();
                    }
                }
            }
            return materialType;
        }
        //添加材料类型信息
        public int InsertMaterialType(Model.MaterialType materType)
        {
            return SQLHelp.ExecQuery("insert into [TypeName],[Desc],[Sate]) values('" + materType.TypeName + "','" + materType.Desc + "','" + materType.State + "',0)");
        }
    }
}
