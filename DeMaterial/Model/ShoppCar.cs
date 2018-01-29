using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //购物车类
    public class ShoppCar
    {
        public ShoppCar() { }
        public ShoppCar(int id, int userid, int materialid, int materialnumCar, int state)
        {
            this.ID = id;
            this.UserID = userid;
            this.MaterialID = materialid;
            this.MaterialNumCar = materialnumCar;
            this.State = state;
        }
        public int ID { get; set; }  //主键ID
        public int UserID { get; set; }  //用户编号
        public int MaterialID { get; set; }  //材料ID
        public int MaterialNumCar { get; set; }  //数量
        public int State { get; set; }    //状态
    }
}
