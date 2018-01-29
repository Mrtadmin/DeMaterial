using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class PartsTypedll
    {
        public List<Model.PartsType> GetPartsType(string where = null)
        {
            List<Model.PartsType> partsType = new List<PartsType>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from [PartsType] where [Sate]=0" + where);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        partsType.Add(new PartsType()
                            {
                                PartsTypeID = (int)dr["PartsTypeID"],
                                PartsTypeName = dr["PartsTypeName"].ToString(),
                                MaterialTypeID = (int)dr["MaterialTypeID"],
                                State = (int)dr["State"],
                            });
                        dr.Close();
                        SQLHelp.CloseConnection();
                    }
                }
            }
            return partsType;
        }

        //添加细分类信息
        public int InsertPartsType(Model.PartsType partsType)
        {
            return SQLHelp.ExecQuery("insert into [PartsTypeName],[MaterialTypeID],[Sate]) values('" + partsType.PartsTypeName + "','" + partsType.MaterialTypeID + "','" + partsType.State + "',0)");
        }
    }
}
