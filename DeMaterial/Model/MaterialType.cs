using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //材料类型类
    public class MaterialType
    {
        public MaterialType() { }
        public MaterialType(int materialTypeID, string typename, string desc, int state)
        {
            this.MaterialTypeID = materialTypeID; ;
            this.TypeName = typename;
            this.Desc = desc;
            this.State = state;
        }
        public int MaterialTypeID { get; set; }  //主键ID
        public string TypeName { get; set; }  //类型名称
        public string Desc { get; set; }  //说明
        public int State { get; set; }  //状态
        
    }
}
