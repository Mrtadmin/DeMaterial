using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class MaterialsRule
    {
        public virtual bool TestInsert(string MaterialName)
        {
            return (int)DAL.SQLHelp.ExecScalar
                ("select count(*) from [Material] where [MaterialName]='" + MaterialName + "'") == 0;
        }
        public bool TestUpdate(string materialname, int materialid)
        {
            return (int)DAL.SQLHelp.ExecScalar
                ("select count(*) from [Material] where [MaterialName]='" + materialname + "' and[UserID]!=" + materialid) == 0;
        }
        public bool TestDelete(int id)
        {
            return (int)DAL.SQLHelp.ExecScalar
                ("select count (*) from [Material] where [MaterialID]=" + id) == 0;
        }
    }
}
