using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class ShoppCardal
    {
        public List<Model.ShoppCar> GetShoppCar(string where = null)
        {
            List<Model.ShoppCar> shoppCar = new List<ShoppCar>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select  MaterialName,MaterialPrice from Material where  Materialnum='50' order by MaterialPrice asc" +where);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        shoppCar.Add(new ShoppCar()
                            {
                                ID = (int)dr["ID"],
                                UserID = (int)dr["UserID"],
                                MaterialID = (int)dr["MaterialID"],
                                MaterialNumCar = (int)dr["MaterialNumCar"],
                                State = (int)dr["State"],
                            });
                        dr.Close();
                        SQLHelp.CloseConnection();
                    }
                }
            }
            return shoppCar;
        }
        //添加购物车信息
        public int InsertShoppCar(Model.ShoppCar shoppcar)
        {
            return SQLHelp.ExecQuery("insert into [UserID],[MaterialID],[MaterialNumCar],[State]) values('" + shoppcar.UserID + "','" + shoppcar.MaterialID + "','" + shoppcar.MaterialNumCar + "','" + shoppcar.State + "',0)");
        }
    }
}
