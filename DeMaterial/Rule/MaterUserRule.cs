using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class MaterUserRule
    {
        /// <summary>
        /// 查询指定的用户名称是否存在
        /// </summary>
        /// <param name="userid">用户名称</param>
        /// <returns>是否存在</returns>
        public bool TestInsert(string userid)
        {
            return (int)DAL.SQLHelp.ExecScalar("select count(*) from [MaterUser] where [UserAccout]='" + userid + "' and [State]=0") == 0;
        }
        /// <summary>
        /// 查询指定的用户编号是否存在相关联的数据
        /// </summary>
        /// <param name="userid">用户编号</param>
        /// <returns>是否存在相关联的数据</returns>
        public bool TestDelete(string userid)
        {
            return true;
        }
    }
}
