using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //材料细分类
    public class PartsType
    {
        public PartsType() { }

        public PartsType(int partsTypeID, string partsTypeName, int materialTypeID, int state)
        {
            this.PartsTypeID = partsTypeID;
            this.PartsTypeName = partsTypeName;
            this.MaterialTypeID = materialTypeID;
            this.State = state;
        }
        public int PartsTypeID { get; set; }  //主键ID
        public string PartsTypeName { get; set; }  //分类名称
        public int MaterialTypeID { get; set; }
        public int State { get; set; }   //状态
    }
}
