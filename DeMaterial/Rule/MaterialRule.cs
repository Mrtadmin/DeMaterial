using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class MaterialRule
    {
        public virtual bool TestInsert(string materialName)
        {
            return (int)DAL.SQLHelp.ExecScalar
                ("select count(*) from [Material] where [MaterialName]='" + materialName + "'") == 0;
        }

        public bool TestUpdate(string materialName, int id)
        {
            return (int)DAL.SQLHelp.ExecScalar("select count(*) from [Material] where [MaterialName]='" + materialName + "' and [ID]!=" + id) == 0;
        }

        public bool TestDelete(int id)
        {
            return (int)DAL.SQLHelp.ExecScalar("select count(*) from [Material] where [MaterialID]=" + id) == 0;
        }
    }
}
